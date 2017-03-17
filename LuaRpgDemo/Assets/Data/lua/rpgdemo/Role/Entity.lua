--游戏中生物的基类
local Entity = {

gName ="",
level = 0,
hp = 0,
maxHp = 0,
mp = 0,
maxMp = 0,
minAct = 0,
maxAct = 0,
wDef = 0,
nDef = 0,
headIconPath = 0,
headIcon = nil,

power = 0,
dex = 0,
intel = 0,
low = 0

}

function Entity:new (o)
	local o = o or {}
	setmetatable(o,self)
	self.__index = self	
	return o
end



return Entity