--人物技能的基类
local Skill = {

id = 0,
name,
icon,
level,
--技能类型，主动还是被动
skillType,
--技能的使用者
skillOwner

}

function Skill:new (o)
	local o = o or {}
	setmetatable(o,self)
	
	self.__index = self
	
	
	o.super = self
	return o
end

function Skill:Before()
	
end

function Skill:Use()
	
end

function Skill:Damage()
	
end

function Skill:SkillEnd()
	
end

return Skill