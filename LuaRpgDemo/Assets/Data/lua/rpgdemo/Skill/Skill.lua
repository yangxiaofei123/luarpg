--���＼�ܵĻ���
local Skill = {

id = 0,
name,
icon,
level,
--�������ͣ��������Ǳ���
skillType,
--���ܵ�ʹ����
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