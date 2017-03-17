--主动技能基类
local Skill = require("rpgdemo/Skill/Skill")

local ActiveSkill = Skill:new{

skillAnim,
skillIndex,
--技能动画名称
skillAnimName,
skillState = SkillStateEnum.INIT,
isNeedTarget = false,
isEnterFighting = false,
coldTime,
lastUseTime = 0,
startTime,
endTime,
buffId,
debuffId,
baseDmg = 0,
dmgType,
skillRange,
attackType,
costMP = 0,
costCP = 0,
costHP = 0,
costGoodsId,
costGoodsNum,
attackMonsterList,
triggerObj

}

function ActiveSkill:SuperInit(player)
	API.Log("ActiveSkill:init")
	self.skillOwner = player
	self.skillAnim = self.skillOwner.gameObject:GetComponent("Animator")
	self.skillState = SkillStateEnum.BEFORE
end

function ActiveSkill:SuperBefore()
	API.Log(" ActiveSkill:Before")
	if self.skillOwner == nil then
		self:exit()
		return false
	end
	
	if self.isNeedTarget then
		--[[print(self.skillOwner.actTarget == nil)--]]
		if self.skillOwner.actTarget == nil then
			print(" no monster target")
			self:exit()
			return false
		end
		if self.skillOwner.actTarget:isLive() ~= true then
			print(" monster target is dead")
			self.skillOwner.actTarget = nil
			self:exit()
			return false
		end
		print(self.skillOwner.actTarget == nil)
		if self:getDistance(self.skillOwner.gameObject, self.skillOwner.actTarget) > self.skillRange then
			print(" monster target is too far")
			self:exit()
			return false
		end
	end
	
	local mp = self.skillOwner.mp
	local costmp = self.costMP	
	local b = (mp < costmp)
	if b then
			
		self:exit()
			
		return false
	end
		

	local hp = self.skillOwner.hp
	local costhp = self.costHP	
	local b1 = (hp < costhp)
	if b1 then
		self:exit()
		return false
	end

	
	local cp = self.skillOwner.cp
	local costcp = self.costCP	
	local b2 = (cp < costcp)
	if b2 then
		self:exit()
		return false
	end
	
    self.skillOwner.mp = self.skillOwner.mp - self.costMP
	self.skillOwner.hp = self.skillOwner.hp - self.costHP
	self.skillOwner.cp = self.skillOwner.cp - self.costCP
	if self.isEnterFighting then
		self.skillOwner.isFighting = true
	end
	self.startTime = Time.realtimeSinceStartup
	return true
end

function ActiveSkill:Use()
	
end

function ActiveSkill:Damage()
	
end

function ActiveSkill:SkillEnd()
	
end

function ActiveSkill:getDistance(obj,target)
	return Vector3.Distance(obj.transform.position,target.transform.position)
end

function ActiveSkill:getDamage()
	return 0
end

function ActiveSkill:cost()
	if self.skillOwner.mp < self.costMP then
		return false
	end
	
	if self.skillOwner.mp < self.costMP then
		return false
	end
	
	if self.skillOwner.mp < self.costMP then
		return false
	end
	self.skillOwner.mp = self.skillOwner.mp - self.costMP
	self.skillOwner.hp = self.skillOwner.hp - self.costHP
	self.skillOwner.cp = self.skillOwner.cp - self.costCP
	
	return true
end

function ActiveSkill:exit()
	self.skillState = SkillStateEnum.SKILLOVER
end

function ActiveSkill:turnHeroRote()
	if self.isNeedTarget and self.skillOwner.actTarget ~=nil then
		local v = self.skillOwner.actTarget.transform.position - self.transform.position
		local angle = Vector3.Angle(v,self.skillOwner.transform.forward)
		
		if Mathf.Abs(angle) >50 then
			self.skillOwner.transform.Rotate(self.skillOwner.transform.up * -angle *2 * Time.deltaTime)
			return
	
		elseif Mathf.Abs(angle) < 47 then
			if Mathf.Abs(angle) < 15 then
				self.transform.localEulerAngles = Vector3(0, self.skillOwner.transform.localEulerAngles.y + 35, 0)
			elseif Mathf.Abs(angle) < 30 then
				self.transform.localEulerAngles = Vector3(0, self.skillOwner.transform.localEulerAngles.y + 25, 0)
			else
				self.transform.localEulerAngles = Vector3(0, self.skillOwner.transform.localEulerAngles.y + 10, 0)
			end
		end
	end
end

function  ActiveSkill:turnRole()
--	API.Log("turnRole")
	local v = self.skillOwner.actTarget.transform.position - self.skillOwner.transform.position
	local angle = Vector3.Angle(v,self.skillOwner.transform.forward)
	if Mathf.Abs(angle) > 20 then
		self.skillOwner.transform:Rotate(self.skillOwner.transform.up * -angle *10 * Time.deltaTime)
		return false
	end
	return true
end

return ActiveSkill