--����UI����
local SkillUI = {}
local this
local gameObject
local transform

--��LuaBehavior.DoFile֮���ڵ���complete��ʱ���Ѿ���Startִ�������
function SkillUI.Start()
	--���Ȱ�Mono��this�ȳ��ñ�������������
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