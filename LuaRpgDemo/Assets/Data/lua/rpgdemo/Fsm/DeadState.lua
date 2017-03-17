--¼Ì³Ð×ÔStateÀà
local State = require("rpgdemo/Fsm/State")

local DeadState = State:new{

monster,
anim,

simpleAi,

destroyTime

}

function DeadState:Init(stateid,fsm,monster)
	
	State.Init(self,stateid,fsm)
	self.monster = monster
	self.anim = self.monster.gameObject:GetComponent("Animator")	
	self.simpleAi = self.monster.simpleAi
	
end

function DeadState:Enter()
	API.Log(self.stateId)
	if self.anim ~= nil then
		print("---------------------------")
		self.anim:SetInteger("AIState",4)
	end
	destroyTime = Time.realtimeSinceStartup
end

function DeadState:Excute()
	if Time.realtimeSinceStartup - destroyTime > 10 then
		self.monster:delObj()
	end
end

function DeadState:Exit()
	
end

return DeadState