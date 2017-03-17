--¼Ì³Ð×ÔEntityÀà
local Entity = require("rpgdemo/Role/Entity")

local Role = Entity:new{

speed = 7,
actRange =3,
actTarget = nil,
isFighting = false,
skillList = nil

}



function Role.init(o)
	
	o.hp = 100
	o.maxHp = 100
	o.mp = 50
	o.maxMp = 50
	o.cp = 100
	o.maxCp = 100
	o.minAct = 2
	o.maxAct = 10
	o.wDef = 3
	o.nDef = 1
	
	skillList = {}
	
end

function Role:isLive()
	
	return self.hp > 0
	
end

function Role:Attack()
	
	self.isFighting = true
	
end

return Role