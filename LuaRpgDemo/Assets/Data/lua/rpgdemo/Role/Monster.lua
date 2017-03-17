--��ͼ��Ĺ�����
local Role = require("rpgdemo/Role/Role")

--monsterҲ��һ��luaBehavior��������Ϊ�����Լ̳�
--���Ա���д��new �̳е� ��ʽ��
local Monster = Role:new{

attackIntervalTime = 1.5,
exp,
expRatio,
isAddAttr,
perfabPath,
modelScale,
alertRange,
followRange,

simpleAi,

mFsm


}

local IDLE = "idle"
local PATROL = "patrol"
local ALERT = "alert"	
local FOLLOW = "follow"	
local ATTACK = "attack"	
local FLEE = "flee"
local DEAD = "dead" 	

function Monster.Start()
	
	this=Monster.this
	transform=Monster.transform
	gameObject=Monster.gameObject
	
	Monster:init()
	
	this.LuaName = "Monster"	
end

function Monster:init()
	--��ʼ�����������
	Role.init(self)
	self.speed = 4
	self.alertRange = 10
	self.followRange = 50
	
	
	
	local lbAI = API.AddComponent(gameObject,"LuaBehaviour")
	lbAI:DoFile("rpgdemo/AI/SimpleAI",function()
		
		local ai_script=lbAI:GetChunk()	
		self.simpleAi = ai_script
		ai_script.InitMonster(self)
		
	end)
	
	--Ϊÿһ�������һ��FSM���
	local lb = API.AddComponent(gameObject,"LuaBehaviour")
	
	lb:DoFile("rpgdemo/Fsm/FSM",function()			
		local fsm_script=lb:GetChunk()	
		self.mFsm = fsm_script
		fsm_script.initEntity(self)
		fsm_script.ChangeState(IDLE)
	end)

end

function Monster:FindTarget()
	
end

function Monster:Attack()
	
	if self.actTarget == nil then
		return
	end
	self.isFighting = true
	
	local damageValue = Random.Range(self.minAct,self.maxAct)
	player:beAttacked(nil, damageValue)
end

function Monster:beAttacked(skill, damageValue)
	print(self.hp.."damageValue:"..damageValue)
	local hurtValue = 0 
	if skill.dmgType == 1 then
		hurtValue = damageValue - self.wDef
	elseif skill.dmgType ==2 then
		hurtValue = damageValue - self.nDef
	end
	
	if hurtValue <= 0 then
		hurtValue = 1
	end
	
	if self.hp - hurtValue < 0 then
		self.hp = 0
	else
		self.hp = self.hp - hurtValue
	end
	API.Broadcast("hitmonster",self)	
	if self:isLive() ~= true then
		self:Dead()
		return
	end
	
	if self.isFighting ~= true then
		local dis = GameUtils.getDistance(self.gameObject,skill.skillOwner.gameObject)
		self.actTarget = skill.skillOwner.gameObject
		if dis <= self.actRange then
			self.mFsm.ChangeState(StateEnum.ATTACK)
		elseif dis > self.actRange then
			self.mFsm.ChangeState(StateEnum.FOLLOW)
		end
	end
	
end

function Monster:Dead()
	self.mFsm.ChangeState(StateEnum.DEAD)
	
end


function Monster:delObj()
	--����д��Monster.gameObjectҲ�С���ΪMonsterû�б�new��������dofile�����ġ�
	--���������Ǹ�luaʵ����
	GameObject.Destroy(self.gameObject)
end

return Monster