﻿using System;
using System.Collections.Generic;
using LuaInterface;

public class ChapterDictionaryWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("get_Item", get_Item),
			new LuaMethod("set_Item", set_Item),
			new LuaMethod("Add", Add),
			new LuaMethod("Clear", Clear),
			new LuaMethod("ContainsKey", ContainsKey),
			new LuaMethod("ContainsValue", ContainsValue),
			new LuaMethod("GetObjectData", GetObjectData),
			new LuaMethod("OnDeserialization", OnDeserialization),
			new LuaMethod("Remove", Remove),
			new LuaMethod("TryGetValue", TryGetValue),
			new LuaMethod("GetEnumerator", GetEnumerator),
			new LuaMethod("New", _CreateChapterDictionary),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("Count", get_Count, null),
			new LuaField("Comparer", get_Comparer, null),
			new LuaField("Keys", get_Keys, null),
			new LuaField("Values", get_Values, null),
		};

		LuaScriptMgr.RegisterLib(L, "ChapterDictionary", typeof(Dictionary<uint,Chapter>), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateChapterDictionary(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(IDictionary<uint,Chapter>)))
		{
			IDictionary<uint,Chapter> arg0 = (IDictionary<uint,Chapter>)LuaScriptMgr.GetNetObject(L, 1, typeof(IDictionary<uint,Chapter>));
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(IEqualityComparer<uint>)))
		{
			IEqualityComparer<uint> arg0 = (IEqualityComparer<uint>)LuaScriptMgr.GetNetObject(L, 1, typeof(IEqualityComparer<uint>));
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(IEqualityComparer<uint>)))
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			IEqualityComparer<uint> arg1 = (IEqualityComparer<uint>)LuaScriptMgr.GetNetObject(L, 2, typeof(IEqualityComparer<uint>));
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>(arg0,arg1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(IDictionary<uint,Chapter>), typeof(IEqualityComparer<uint>)))
		{
			IDictionary<uint,Chapter> arg0 = (IDictionary<uint,Chapter>)LuaScriptMgr.GetNetObject(L, 1, typeof(IDictionary<uint,Chapter>));
			IEqualityComparer<uint> arg1 = (IEqualityComparer<uint>)LuaScriptMgr.GetNetObject(L, 2, typeof(IEqualityComparer<uint>));
			Dictionary<uint,Chapter> obj = new Dictionary<uint,Chapter>(arg0,arg1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Dictionary<uint,Chapter>.New");
		}

		return 0;
	}

	static Type classType = typeof(Dictionary<uint,Chapter>);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Count(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Count");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Count on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Count);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Comparer(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Comparer");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Comparer on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.Comparer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Keys(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Keys");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Keys on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.Keys);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Values(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Values");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Values on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.Values);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		Chapter o = obj[arg0];
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		Chapter arg1 = (Chapter)LuaScriptMgr.GetNetObject(L, 3, typeof(Chapter));
		obj[arg0] = arg1;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		Chapter arg1 = (Chapter)LuaScriptMgr.GetNetObject(L, 3, typeof(Chapter));
		obj.Add(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		obj.Clear();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ContainsKey(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		bool o = obj.ContainsKey(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ContainsValue(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		Chapter arg0 = (Chapter)LuaScriptMgr.GetNetObject(L, 2, typeof(Chapter));
		bool o = obj.ContainsValue(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetObjectData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		System.Runtime.Serialization.SerializationInfo arg0 = (System.Runtime.Serialization.SerializationInfo)LuaScriptMgr.GetNetObject(L, 2, typeof(System.Runtime.Serialization.SerializationInfo));
		System.Runtime.Serialization.StreamingContext arg1 = (System.Runtime.Serialization.StreamingContext)LuaScriptMgr.GetNetObject(L, 3, typeof(System.Runtime.Serialization.StreamingContext));
		obj.GetObjectData(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeserialization(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		object arg0 = LuaScriptMgr.GetVarObject(L, 2);
		obj.OnDeserialization(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		bool o = obj.Remove(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TryGetValue(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		uint arg0 = (uint)LuaScriptMgr.GetNumber(L, 2);
		Chapter arg1 = null;
		bool o = obj.TryGetValue(arg0,out arg1);
		LuaScriptMgr.Push(L, o);
		LuaScriptMgr.PushObject(L, arg1);
		return 2;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Dictionary<uint,Chapter> obj = (Dictionary<uint,Chapter>)LuaScriptMgr.GetNetObjectSelf(L, 1, "Dictionary<uint,Chapter>");
		Dictionary<uint,Chapter>.Enumerator o = obj.GetEnumerator();
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

