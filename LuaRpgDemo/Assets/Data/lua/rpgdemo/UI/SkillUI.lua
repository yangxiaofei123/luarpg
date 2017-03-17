--技能UI控制
local SkillUI = {}
local this
local gameObject
local transform

--在LuaBehavior.DoFile之后，在调用complete的时候，已经把Start执行完毕了
function SkillUI.Start()
	--首先把Mono的this等常用变量缓存起来。
	this=SkillUI.this
	transform=SkillUI.transform
	gameObject=SkillUI.gameObject	
	
	this.usingUpdate=true
end

function SkillUI.Update()
	SkillUI.useSkill()
end

function SkillUI.useSkill()
	if Input.GetKeyUp("1") then
		API.Log(" skill one ")
		player.skillSystem:useSkill(player.acSkillList["1"])
	end
end

return SkillUI