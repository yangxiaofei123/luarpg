--地图系统，负责地图场景的变换。怪物的生成
local MapSystem = {}


--在LuaBehavior.DoFile之后，在调用complete的时候，已经把Start执行完毕了
function MapSystem.Start()
	
	--初始化第一张地图
	
	MapSystem.InitMonsters()
	
	
end

function MapSystem.InitPlayerPos()
	
	player.transform.position = Vector3(203,0,165)	
	
end

function MapSystem.InitMonsters()
	
	local monsterGO = GameObject.Instantiate(Resources.Load("prefabs/Monster/Goblin"))
	monsterGO.name = "monster"
	monsterGO.transform.position = Vector3(203,0,180)
	local lbmonster = API.AddComponent(monsterGO,"LuaBehaviour")
	lbmonster:DoFile("rpgdemo/Role/Monster",function()
		
		local monster_script=lbmonster:GetChunk()	
		
		
	end)
	
		
	local monsterGO1 = GameObject.Instantiate(Resources.Load("prefabs/Monster/Goblin"))
	monsterGO1.name = "monster1"
	monsterGO1.transform.position = Vector3(188,0,180)
	local lbmonster1 = API.AddComponent(monsterGO1,"LuaBehaviour")
	lbmonster1:DoFile("rpgdemo/Role/Monster",function()
		
		local monster_script=lbmonster1:GetChunk()			
		
	end)
	
end

return MapSystem
















