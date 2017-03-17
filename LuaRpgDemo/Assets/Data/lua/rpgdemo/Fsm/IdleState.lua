--¼Ì³Ð×ÔStateÀà
local State = require("rpgdemo/Fsm/State")

local IdleState = State:new{

monster,
anim,

simpleAi

}

function IdleState:Init(stateid,fsm,monster)
	
	State.Init(self,stateid,fsm)
	self.monster = monster
	self.anim = self.monster.gameObject:GetComponent("Animator")	
	self.simpleAi = self.monster.simpleAi
end

function IdleState:Enter()
	API.Log(self.stateId)
	if self.anim ~= nil then
		self.anim:SetInteger("AIState",0)
	end
end

function IdleState:Excute()
	
	if  self.simpleAi ~= nil and self.simpleAi.FindEnemy() then
		self.mFSM.ChangeState(StateEnum.ALERT)
	end
end

function IdleState:Exit()
	if anim ~= nil then
		anim:StopPlayback()
	end
end

return IdleState