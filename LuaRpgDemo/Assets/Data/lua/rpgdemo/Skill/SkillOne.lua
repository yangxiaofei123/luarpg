--第一个技能
local ActiveSkill = require("rpgdemo/Skill/ActiveSkill")

local SkillOne = ActiveSkill:new()
local isFighting = Animator.StringToHash("isFighting");
local isJump = Animator.StringToHash("isJump");
function SkillOne:init(role)
	API.Log("SkillOne:init")
	
	self:SuperInit(role)
	
	self.id = 10001
	self.icon = ""
	self.skillIndex = 2
	self.isNeedTarget = true
	self.name = "skillone"
	self.skillAnimName = "Skill1"
	
	self.baseDmg = 10
	self.dmgType = 1
	self.costCP = 5
	self.costMP = 0
	self.costHP = 0
	self.level = 1
	self.attackType = 1
	self.skillRange = 3.5
	self.coldTime = 1.5
	self.endTime = 1.2
	self.isEnterFighting = true
	
	
	
end

function SkillOne:Before()
	
	API.Log("before")
	if self.isNeedTarget and self.skillOwner.actTarget ~= nil then
		if(self:turnRole()~= true) then
			return false
		end
	else
		--[[return false--]]
	end
	
	if self:SuperBefore() then
		self.startTime = Time.realtimeSinceStartup
		self.skillState = SkillStateEnum.USE
		return true
	end
	
	return false
end

function SkillOne:Use()
	API.Log("Use")
	self.skillAnim:SetInteger("skillIndex", self.skillIndex)
	if Time.realtimeSinceStartup - self.startTime >0.7 then
		self.skillState = SkillStateEnum.DAMAGE
	end
	
end

function SkillOne:Damage()
	API.Log("Damage")
	self.skillOwner.actTarget:beAttacked(self, self:getDmg());
	self.skillState = SkillStateEnum.SKILLEND
	
end

function SkillOne:SkillEnd()
	
	
	local animInfo = self.skillAnim:GetCurrentAnimatorStateInfo(0)

	if animInfo:IsName(self.skillName) and animInfo.normalizedTime >= 1 then
		self.skillAnim:SetInteger("skillIndex", 0)
	end
--	print(Time.realtimeSinceStartup - self.startTime > self.endTime)
	if Time.realtimeSinceStartup - self.startTime > self.endTime then
		self.skillAnim:SetInteger("skillIndex", 0)
		self.skillState = SkillStateEnum.SKILLOVER
	end
	if(self.skillOwner.actTarget ~= nil) then
		if self.skillOwner.actTarget:isLive() ~= true then
				print(" monster target is dead------SkillEnd")
				self.skillOwner.actTarget = nil
				--self.skillAnim:SetBool(isFighting,false)
				--self.skillOwner.isFighting = false
				--self:exit()
				
		end
    end

end

function SkillOne:getDmg()
	local damageVal = 0
	damageVal = Random.Range(self.skillOwner.minAct, self.skillOwner.maxAct)
	damageVal = damageVal + self.baseDmg * self.level
	
	return damageVal
end

return SkillOne