--人物UI控制
local PlayerStateUI = {}
local this
local gameObject
local transform

local uiCanvas
local HPSlider
local Slider
local HPValue
local HPText

local MonsterHPSlider
local MonsterHeadImg
local MonsterVal
local MonsterValTxt
local MonsterSlider

--在LuaBehavior.DoFile之后，在调用complete的时候，已经把Start执行完毕了
function PlayerStateUI.Start()
	--首先把Mono的this等常用变量缓存起来。
	this=PlayerStateUI.this
	transform=PlayerStateUI.transform
	gameObject=PlayerStateUI.gameObject	
	
	HPSlider=  transform:FindChild("HPSlider")	
	Slider = HPSlider:GetComponent("Slider")
	HPValue =  transform:FindChild("HPVal")
	HPText = HPValue:GetComponent("Text")	
	
	Slider.maxValue = player.maxHp
	Slider.value = player.hp
	HPText.text = "体力:".. player.hp .."/"..player.maxHp
		
	MonsterHPSlider=  transform:FindChild("MonsterHPSlider")	
	MonsterHeadImg=  transform:FindChild("MonsterHeadImage")	
	MonsterVal =  transform:FindChild("MonsterHPVal")	
	MonsterSlider = MonsterHPSlider:GetComponent("Slider")	
	MonsterValTxt = MonsterVal:GetComponent("Text")	
	MonsterValTxt.text = "体力:"
	
	MonsterHPSlider.gameObject:SetActive(false)
	MonsterSlider.gameObject:SetActive(false)
	MonsterHeadImg.gameObject:SetActive(false)
	MonsterValTxt.gameObject:SetActive(false)
	
	API.AddListener2("hitplayer",PlayerStateUI.ChangeHP)
	API.AddListener2("findmonster",PlayerStateUI.FindMonster)
	API.AddListener2("hitmonster",PlayerStateUI.ChangeMonsterHP)
	this.usingUpdate=true
end

function PlayerStateUI.Update()
	
end

function PlayerStateUI.ChangeHP()
	Slider.value = player.hp
	HPText.text = "体力:"..player.hp .."/"..player.maxHp
end

function PlayerStateUI.ChangeMonsterHP(monster)
	MonsterSlider.value = monster.hp
	MonsterValTxt.text = "体力:"..monster.hp .."/"..monster.maxHp	
end

function PlayerStateUI.FindMonster(actTarget)
	if(actTarget ~= nil) then
		MonsterHPSlider.gameObject:SetActive(true)
		MonsterSlider.gameObject:SetActive(true)
		MonsterHeadImg.gameObject:SetActive(true)
		MonsterValTxt.gameObject:SetActive(true)
		
		MonsterSlider.maxValue = actTarget.maxHp
		MonsterSlider.value = actTarget.hp
		
		MonsterValTxt.text = "体力:"..actTarget.hp .."/"..actTarget.maxHp	
	else 
		MonsterHPSlider.gameObject:SetActive(false)
		MonsterSlider.gameObject:SetActive(false)	
		MonsterHeadImg.gameObject:SetActive(false)
		MonsterValTxt.gameObject:SetActive(false)
	end
end

return PlayerStateUI