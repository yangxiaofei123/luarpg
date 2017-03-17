--×´Ì¬µÄ»ùÀà
local State = {

stateId = "",
mFSM

}

function State:new (o)
	local o = o or {}
	setmetatable(o,self)
	self.__index = self
	return o
end

function State.Init(o,stateid,fsm)
	o.stateId = stateid
	o.mFSM = fsm
end

function State:Enter()
	
end

function State:Excute()
	
end

function State:Exit()
	
end

function State:Refresh()
	
end

return State