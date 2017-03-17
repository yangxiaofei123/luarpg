--绑定在怪物身上的Lua脚本。AI功能
local SimpleAI = {}

local this
local gameObject
local transform



local anim 

--怪物身上的Monster脚本
local monster 

--给table赋值必须有初始值。像local xx这样的声明不用
SimpleAI.hero = nil
SimpleAI.dis = 0
SimpleAI.agent = nil
SimpleAI.lastAttackTime = 0

--在LuaBehavior.DoFile之后，在调用complete的时候，已经把Start执行完毕了
function SimpleAI.Start()
	--首先把Mono的this等常用变量缓存起来。
	this=SimpleAI.this
	transform=SimpleAI.transform
	gameObject=SimpleAI.gameObject
	--英雄Hero的脚本
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