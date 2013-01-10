
namespace haxe.lang
{
	public  class FieldLookup : haxe.lang.HxObject 
	{
		public    FieldLookup() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  Array<int> fieldIds = new Array<int>(new int[]{98, 4745537, 4846113, 5144726, 5442212, 5443986, 5594513, 5741474, 5790298, 23697287, 76061764, 89600725, 116192081, 139469119, 142301684, 276486854, 294420221, 302979532, 304123084, 328878574, 389604418, 407283053, 452737314, 480756972, 501039929, 520590566, 520665567, 589796196, 602588383, 674101152, 757431474, 845179051, 853263683, 896046654, 922671056, 931940005, 937216258, 946786476, 967979664, 987108662, 995006396, 999946793, 1003238327, 1041537810, 1067353468, 1071652316, 1103412149, 1167273324, 1181037546, 1191633396, 1204816148, 1224700491, 1224901875, 1247875546, 1261760260, 1280549057, 1280845662, 1282943179, 1313416818, 1328964235, 1352786672, 1395555037, 1416948632, 1431885287, 1471506513, 1532710347, 1537812987, 1547539107, 1575675685, 1620824029, 1621420777, 1635357710, 1639293562, 1641152943, 1648581351, 1705629508, 1723652455, 1744813180, 1797611211, 1836776262, 1856815770, 1895479501, 1909937370, 1915412854, 1916009602, 1955029599, 1962709206, 1981972957, 2012934199, 2022294396, 2025055113, 2048392659, 2082663554, 2084789794, 2084823382, 2113708439, 2117141633, 2122408236, 2127021138, 2134927590});
		
		public static  Array<object> fields = new Array<object>(new object[]{"b", "__a", "add", "get", "max", "min", "pop", "set", "tag", "speed", "remove", "CompareTag", "target", "SendMessage", "resize", "GetInstanceID", "SendMessageUpwards", "methodName", "ToString", "iterator", "Start", "hasNext", "reverse", "nOccupied", "insert", "length", "addSub", "getTag", "IsInvoking", "guiTexture", "CancelInvoke", "quotient", "renderer", "useGUILayout", "cachedIndex", "camera", "Trim", "toString", "GetComponentsInChildren", "StartCoroutine", "hashes", "Update", "DestroyImmediate", "index", "splice", "exists", "copy", "transform", "join", "keys", "concat", "name", "next", "push", "animation", "size", "sort", "quicksort", "vals", "GetComponentInChildren", "spliceVoid", "cachedKey", "Invoke", "constantForce", "gameObject", "concatNative", "nBuckets", "className", "hideFlags", "__unsafe_get", "__unsafe_set", "DontDestroyOnLoad", "lookup", "InvokeRepeating", "fileName", "toDynamic", "GetComponent", "constructs", "getDefault", "params", "StopAllCoroutines", "rigidbody", "Destroy", "__get", "__set", "Equals", "light", "lineNumber", "modulus", "upperBound", "unshift", "_keys", "shift", "__hx_createEmpty", "StopCoroutine", "addChar", "enabled", "GetComponents", "slice", "BroadcastMessage"});
		
		public static   int doHash(string s)
		{
			unchecked 
			{
				int acc = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						acc = ( ( ( 223 * (( acc >> 1 )) ) + haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
					}
					
				}
				
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
		}
		
		
		public static   string lookupHash(int key)
		{
			unchecked 
			{
				Array<int> ids = haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				while (( min < max ))
				{
					int mid = ( min + ( (( max - min )) / 2 ) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( key > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							return haxe.lang.Runtime.toString(haxe.lang.FieldLookup.fields[mid]);
						}
						
					}
					
				}
				
				throw haxe.lang.HaxeException.wrap(haxe.lang.Runtime.concat("Field not found for hash ", haxe.lang.Runtime.toString(key)));
			}
		}
		
		
		public static   int hash(string s)
		{
			unchecked 
			{
				if (string.Equals(s, default(string))) 
				{
					return 0;
				}
				
				int key = default(int);
				{
					int acc = 0;
					{
						int _g1 = 0;
						int _g = s.Length;
						while (( _g1 < _g ))
						{
							int i = _g1++;
							acc = ( ( ( 223 * (( acc >> 1 )) ) + haxe.lang.StringExt.charCodeAt(s, i).@value ) << 1 );
						}
						
					}
					
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				Array<int> ids = haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = ids.length;
				while (( min < max ))
				{
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( key > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							string field = haxe.lang.Runtime.toString(haxe.lang.FieldLookup.fields[mid]);
							if ( ! (string.Equals(field, s)) ) 
							{
								return  ~ (key) ;
							}
							
							return key;
						}
						
					}
					
				}
				
				ids.insert(min, key);
				haxe.lang.FieldLookup.fields.insert(min, s);
				return key;
			}
		}
		
		
		public static   int findHash(int hash, Array<int> hashs)
		{
			unchecked 
			{
				int min = 0;
				int max = hashs.length;
				while (( min < max ))
				{
					int mid = ( (( max + min )) / 2 );
					int imid = hashs[mid];
					if (( hash < imid )) 
					{
						max = mid;
					}
					 else 
					{
						if (( hash > imid )) 
						{
							min = ( mid + 1 );
						}
						 else 
						{
							return mid;
						}
						
					}
					
				}
				
				return  ~ (min) ;
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.FieldLookup(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.FieldLookup();
			}
		}
		
		
		public    FieldLookup(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
	}
}


