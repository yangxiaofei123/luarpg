--绑定在怪物身上的Lua脚本。AI功能
local SkillSystem = {}
SkillSystem.nowAttackSkill = nil
local this
local gameObject
local transform

function SkillSystem.Start()
	--首先把Mono的this等常用变量缓存起来。
	this=SkillSystem.this
	transform=SkillSystem.transform
	gameObject=SkillSystem.gameObject
	
	this.usingUpdate=true
end

function SkillSystem.Update()
	if (SkillSystem.nowAttackSkill ~= nil) then
		 
        
		if (SkillSystem.nowAttackSkill.skillState == SkillStateEnum.BEFORE) then
		
			SkillSystem.nowAttackSkill:Before();
		
		elseif (SkillSystem.nowAttackSkill.skillState == SkillStateEnum.USE) then
		
			SkillSystem.nowAttackSkill:Use()
		
		elseif (SkillSystem.nowAttackSkill.skillState == SkillStateEnum.DAMAGE) then
		
			SkillSystem.nowAttackSkill:Damage()
		
		elseif (SkillSystem.nowAttackSkill.skillState == SkillStateEnum.SKILLEND) then
		
			SkillSystem.nowAttackSkill:SkillEnd()
		
		elseif (SkillSystem.nowAttackSkill.skillState == SkillStateEnum.SKILLOVER)then
	   
			SkillSystem.nowAttackSkill = nil;
		
		end
	end
		
end

function SkillSystem:useSkill(skill)
	
	if self.nowAttackSkill == nil then 
		if Time.realtimeSinceStartup - skill.lastUseTime >= skill.coldTime then
			
			skill:init(player)

			self.nowAttackSkill = skill
			self.nowAttackSkill.lastUseTime = Time.realtimeSinceStartup
		else 
			print("skill is cold down")
		end 
	end
end



return SkillSystem