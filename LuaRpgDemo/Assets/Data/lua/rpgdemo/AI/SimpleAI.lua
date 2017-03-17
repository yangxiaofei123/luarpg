--���ڹ������ϵ�Lua�ű���AI����
local SimpleAI = {}

local this
local gameObject
local transform



local anim 

--�������ϵ�Monster�ű�
local monster 

--��table��ֵ�����г�ʼֵ����local xx��������������
SimpleAI.hero = nil
SimpleAI.dis = 0
SimpleAI.agent = nil
SimpleAI.lastAttackTime = 0

--��LuaBehavior.DoFile֮���ڵ���complete��ʱ���Ѿ���Startִ�������
function SimpleAI.Start()
	--���Ȱ�Mono��this�ȳ��ñ�������������
	this=SimpleAI.this
	transform=SimpleAI.transform
	gameObject=SimpleAI.gameObject
	--Ӣ��Hero�Ľű�
	SimpleAI.hero = player	


	anim = this:GetComponent("Animator")
	SimpleAI.agent = this:GetComponent("NavMeshAgent")	
	
	
	
	
end

function SimpleAI.Update()
	if (monster:isLive() ~= true) then
		return 
	end
	
	anim:SetFloat("Speed", SimpleAI.agent.speed)
	
end

function SimpleAI.InitMonster(mon)
	monster = mon
	
	SimpleAI.agent.enabled = false
	SimpleAI.agent.speed = monster.speed
	monster.actTarget = nil
	
	this.usingUpdate=true
end

function SimpleAI.FindEnemy()
	SimpleAI.dis = Vector3.Distance(transform.position, SimpleAI.hero.transform.position)
	if (SimpleAI.dis <= monster.alertRange) then
		return true
	end
	
	return false
end



return SimpleAI