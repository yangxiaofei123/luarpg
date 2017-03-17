local GameUtils = {}

function GameUtils.getDistance(obj,target)
	return Vector3.Distance(obj.transform.position,target.transform.position)
end

--鼠标点击屏幕，选取点中的怪物
function GameUtils.mouseClickFindTarget()
	
	local ray = Camera.main:ScreenPointToRay(Input.mousePosition)
	local ok, hit = Physics.Raycast(ray,Slua.out,100)
	print(ok)
	if(ok) then
		local hitObj = hit.collider.gameObject
		return GameUtils.getLuaByName(hitObj,"Monster")
	end
	return nil
end
--检查当前这个GameObject是不是一个怪物
function GameUtils.checkLuaName(go,name)
	
	local goArray = go:GetComponents("LuaBehaviour")
		
	for v in Slua.iter(goArray) do		
		if v.LuaName == name then			
			return true
		end
	end
	
	return false
end
--根据名字获取绑定的lua脚本
function GameUtils.getLuaByName(go,name)
	
	local goArray = go:GetComponents("LuaBehaviour")
	
	for v in Slua.iter(goArray) do		
		if v.LuaName == name then			
			return v:GetChunk()
		end
	end
	
	return nil
end

--利用碰撞器收集玩家的怪物，在Tab自动选取怪物里面使用
function GameUtils.tabFindTarget()
	return nil
end

function GameUtils.table_maxn(t)
    local mn = 0
    for k, v in pairs(t) do
        if mn < k then
            mn = k
        end
    end
    return mn
end


return GameUtils