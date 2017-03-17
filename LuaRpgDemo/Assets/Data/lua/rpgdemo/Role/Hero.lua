--��ҽ�ɫ��
local Role = require("rpgdemo/Role/Role")
local SkillOne = require("rpgdemo/Skill/SkillOne")
local Hero = Role:new{

gravity = 10,
jumpSpeed = 8,
isDaZuo = false,
exp = 0,
nextExp = 0,
targetEffect = nil,
triggerObj = nil,
acSkillList = {},
skillSystem = nil
}
local this
local gameObject
local transform

function Hero.Start()
	--���Ȱ�Mono��this�ȳ��ñ�������������
	this=Hero.this
	transform=Hero.transform
	gameObject=Hero.gameObject
	
	Hero:init()
	--��ʼ������ļ���ϵͳ
	local skillOne = SkillOne:new()
	skillOne:init(Hero)
	Hero.acSkillList["1"] = skillOne
	
	--��������Ӵ�����
	if Hero.triggerObj == nil then
		
		local colliderGO = GameObject.Instantiate(Resources.Load("prefabs/Tool/SphereCollider"))
		colliderGO.transform.parent = transform
		colliderGO.transform.position = transform.position

		local lbcollider = API.AddComponent(colliderGO,"LuaBehaviour")
		lbcollider:DoFile("rpgdemo/Util/TriggerCollector",function()
		
			local collider_script=lbcollider:GetChunk()	
			Hero.triggerObj = collider_script
					
		end)
		
	end
	
	--�������һ������
	local weapon = GameObject.Instantiate(Resources.Load("prefabs/Goods/Weapon/heroSword"))
	local weapontransform = GameObject.Find("Weapon").transform
	weapon.transform.parent = weapontransform.parent
	weapon.transform.position = weapontransform.position
	weapon.transform.localPosition = Vector3.zero
	
	
	--����C# �ű��󶨵�lua�ű�������
	this.LuaName = "Hero"
	this.usingUpdate=true
end

function Hero.Update()
	Hero:findTarget()
--	Hero.recover()
end

function Hero:findTarget()
	if Input.GetMouseButtonDown(0) then
		print("----------findTarget")
		self.actTarget = GameUtils.mouseClickFindTarget()
		print(self.actTarget == nil)
		API.Broadcast("findmonster",self.actTarget)	
	elseif Input.GetKeyUp(KeyCode.Tab) then
		self.actTarget = GameUtils.tabFindTarget()
	end
	
	if self.actTarget ~= nil then
		--ѡ�й������Ч
	else
		self.isFighting = false
	end
end

--�������ҵķ����������˺�ֵ���ͷ������ȽϺ���͵�һѪ
function Hero:beAttacked(attckSkill, dmgValue)
	local hurtValue = 0 
	hurtValue = dmgValue - self.wDef
	if hurtValue <= 0 then
		hurtValue = 1
	end
	
	if self.hp - hurtValue < 0 then
		self.hp = 0
	else 
		self.hp = self.hp - hurtValue
	end	
	
	API.Broadcast("hitplayer",self.hp)	
end

function Hero:recover()
	
end

return Hero