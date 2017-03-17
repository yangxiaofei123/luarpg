--¼Ì³Ð×ÔStateÀà
local State = require("rpgdemo/Fsm/State")

local AlertState = State:new{

monster,
anim,
simpleAi,

alertTime

}

function AlertState:Init(stateid,fsm,monster)
	State.Init(self,stateid,fsm)
	self.monster = monster
	self.anim = self.monster.gameObject:GetComponent("Animator")	
	self.simpleAi = self.monster.simpleAi
	
end

function AlertState:Enter()
	API.Log(self.stateId)
	self.alertTime = Time.time
end

function AlertState:Excute()
	self.monster.transform:LookAt(self.simpleAi.hero.transform)
	
	if self.simpleAi.FindEnemy() then 
		if Time.time - self.alertTime >= 2 then
			self.monster.actTarget = self.simpleAi.hero
			self.mFSM.ChangeState(StateEnum.FOLLOW)
		end
	else
		self.mFSM.ChangeState(StateEnum.IDLE)
	end
end

function AlertState:Exit()
	if self.anim ~= nil then
		self.anim:StopPlayback()
	end
	self.alertTime = 0
end

return AlertState