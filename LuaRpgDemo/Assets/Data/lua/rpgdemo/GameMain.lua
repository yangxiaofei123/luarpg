
--先从main.lua里面创建GameMain这个GameObject。然后向这个GameMain上绑定LuaBehavior，执行此lua脚本。
--这个脚本是rpg游戏的入口，也是游戏全局的管理类，这里会执行初始化角色，地图，UI。
--GameMain是个局部的table
local GameMain={}

--Lua中的变量，声明的时候必须赋值。
local player = nil

local mainGameObject
--初始化一个全局变量，替代enum的功能
StateEnum = require("rpgdemo/Util/StateEnum")
SkillStateEnum = require("rpgdemo/Util/SkillStateEnum")
GameUtils = require("rpgdemo/Util/GameUtils")

--当LuaBehavior里面执行DoFile lua脚本成功后，就开始执行Start方法。
function GameMain.Start()
	
	--this是LuaBehavior里的对象。也就是MonoBehavior的this，还有transform，gameObject。
	--还可以通过LuaBehavior的SetEnv方法，向全局变量_G里面或者是当前的这个Luatable脚本中添加属性
	this=GameMain.this
	mainGameObject = GameMain.gameObject
	
	GameMain.Init()
	
end

--初始化角色和UI，地图
function GameMain.Init()
	
	--初始化英雄
	--Slua不支持泛型。比如写成这样：Resources.Load<GameObject>
	local playerGO = GameObject.Instantiate(Resources.Load("prefabs/Hero/Hero"))
	playerGO.name = "Player"
	local lbhero = API.AddComponent(playerGO,"LuaBehaviour")
	lbhero:DoFile("rpgdemo/Role/Hero",function()
		
		--测试继承lua脚本
		local hero_script=lbhero:GetChunk()	
		player = hero_script
 		--API.Log("ss"..hero_script.maxMp)
		--把player设置为全局变量，方便其他脚本访问，之后想想办法
		--用传递参数的方式。
		lbhero:SetEnv("player",player,true)
		
	end)
	
	--添加人物控制脚本
	local lbMove = API.AddComponent(playerGO,"LuaBehaviour")
	lbMove:DoFile("rpgdemo/Action/HeroMove",function()			
		
	end)
	
	--添加人物的动画
	local lbAnim = API.AddComponent(playerGO,"LuaBehaviour")
	lbAnim:DoFile("rpgdemo/Action/HeroAnimatorController",function()			
		
	end)
	
	--添加摄像机跟随脚本
	local lbcamera = API.AddComponent(playerGO,"LuaBehaviour")
	lbcamera:DoFile("rpgdemo/Action/CameraController",function()			
		
	end)
	
	--添加技能系统
	local lbSkill = API.AddComponent(playerGO,"LuaBehaviour")
	lbSkill:DoFile("rpgdemo/Skill/SkillSystem",function()			
		local skill_script=lbSkill:GetChunk()	
		
		player.skillSystem = skill_script
	end)
	
	--初始化UI
	local ui = GameObject.Instantiate(Resources.Load("prefabs/UI/PlayerUI"))
	ui.name = "GameUI"
	
	local lbSkillUI = API.AddComponent(ui,"LuaBehaviour")
	lbSkillUI:DoFile("rpgdemo/UI/SkillUI",function()			
		
	end)
	
	local lbSkillUI = API.AddComponent(ui,"LuaBehaviour")
	lbSkillUI:DoFile("rpgdemo/UI/PlayerStateUI",function()			
		
	end)
	
	GameObject.DontDestroyOnLoad(playerGO)
	GameObject.DontDestroyOnLoad(ui)
	GameObject.DontDestroyOnLoad(mainGameObject)
	
	--地图管理系统初始化
	GameMain.InitMapSystem()
	
end

function GameMain.InitMapSystem()
	
	--初始化地图系统
	local lb = API.AddComponent(mainGameObject,"LuaBehaviour")
	lb:DoFile("rpgdemo/MapSystem",function()
		
		--获取绑定的lua脚本
		local map_script=lb:GetChunk()	
			
		--把英雄赋给MapSystem,1.通过LuaBehavior的方法给绑定的脚本，
		--赋值英雄的引用，然后调用Lua脚本里面的方法。2.player直接就是个全局变量。
		--这里尽量不用全局变量，而把player从GameMain这里通过参数传递给MapSystem
--		lb:SetEnv("player",player,false)
		map_script.InitPlayerPos()
	end)
	
	
	
	
	--进入第一张地图
	SceneManagement.SceneManager.LoadScene(2)
end

--必须要return 这个lua脚本，要不不会调用约定好的方法，比如start
return GameMain