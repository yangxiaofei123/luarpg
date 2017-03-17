--继承自State类
local State = require("rpgdemo/Fsm/State")

local FollowState = State:new{

monster,
anim,

simpleAi

}

function FollowState:Init(stateid,fsm,monster)
	State.Init(self,stateid,fsm)
	self.monster = monster
	self.anim = self.monster.gameObject:GetComponent("Animator")	
	self.simpleAi = self.monster.simpleAi
	
end

function FollowState:Enter()
	API.Log(self.stateId)
	if self.monster.actTarget == nil then
		self.mFSM.ChangeState(StateEnum.IDLE)
	end
	
	if self.anim ~= nil then
		self.anim:SetInteger("AIState",2)
	end
end

function FollowState:Excute()
	self.monster.transform:LookAt(self.monster.actTarget.transform)
	--计算本小怪与玩家的距离
	self.simpleAi.FindEnemy()
	
	if self:getDistance(self.monster.gameObject, self.monster.actTarget)> self.monster.followRange then
		self.mFSM.ChangeState(StateEnum.IDLE)
		return
	end
	
	if self.simpleAi.dis <= self.monster.actRange then
		
		self.mFSM.ChangeState(StateEnum.ATTACK)
		
	else
		self.simpleAi.agent.enabled = true
		
		if self.monster.actTarget ~= nil then
			
			self.simpleAi.agent.destination = self.monster.actTarget.transform.position
			
		end
	end
end

function FollowState:getDistance(obj,target)
	return Vector3.Distance(obj.transform.position,target.transform.position)
end

function FollowState:Exit()
	
end

return FollowState