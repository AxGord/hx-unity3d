
public  class Hash<T> : haxe.lang.HxObject, Hash 
{
	public    Hash() : base()
	{
		unchecked 
		{
			Hash<object>.__hx_ctor<T>(this);
		}
	}
	
	
	public static   void __hx_ctor<T2>(Hash<T2> __temp_me8)
	{
		unchecked 
		{
			__temp_me8.cachedIndex = -1;
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Hash<object>(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Hash<object>();
		}
	}
	
	
	public    Hash(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	   object Hash.cast<T1>()
	{
		unchecked 
		{
			if (haxe.lang.Runtime.typeEq(typeof(T), typeof(T1))) 
			{
				return this;
			}
			
			Hash<T1> new_me = new Hash<T1>(haxe.lang.EmptyObject.EMPTY);
			{
				object __temp_iterator16 = Reflect.fields(this).iterator();
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator16, "hasNext", 407283053, default(Array))) ))
				{
					string field = haxe.lang.Runtime.toString(haxe.lang.Runtime.callField(__temp_iterator16, "next", 1224901875, default(Array)));
					switch (field)
					{
						case "vals":
						{
							{
								T1[] __temp_new_arr5 = new T1[this.vals.Length];
								int __temp_i6 = -1;
								while ((  ++ __temp_i6 < this.vals.Length ))
								{
									object __temp_obj7 = ((object) (this.vals[__temp_i6]) );
									if ( ! (( __temp_obj7 == default(T[]) )) ) 
									{
										__temp_new_arr5[__temp_i6] = haxe.lang.Runtime.genericCast<T1>(__temp_obj7);
									}
									
								}
								
								new_me.vals = __temp_new_arr5;
							}
							
							break;
						}
						
						
						default:
						{
							Reflect.setField(new_me, field, ((object) (Reflect.field(this, field)) ));
							break;
						}
						
					}
					
				}
				
			}
			
			return new_me;
		}
	}
	
	
	public virtual   string toString()
	{
		unchecked 
		{
			StringBuf s = new StringBuf();
			s.b.Append(Std.@string("{"));
			object it = this.keys();
			{
				object __temp_iterator17 = it;
				while (((bool) (haxe.lang.Runtime.callField(__temp_iterator17, "hasNext", 407283053, default(Array))) ))
				{
					string i = haxe.lang.Runtime.toString(haxe.lang.Runtime.callField(__temp_iterator17, "next", 1224901875, default(Array)));
					s.b.Append(Std.@string(i));
					s.b.Append(Std.@string(" => "));
					s.b.Append(Std.@string(Std.@string((this.@get(i)).toDynamic())));
					if (((bool) (haxe.lang.Runtime.callField(it, "hasNext", 407283053, default(Array))) )) 
					{
						s.b.Append(Std.@string(", "));
					}
					
				}
				
			}
			
			s.b.Append(Std.@string("}"));
			return s.toString();
		}
	}
	
	
	public virtual   object iterator()
	{
		unchecked 
		{
			Array<object> _g1 = new Array<object>(new object[]{this});
			Array<int> i = new Array<int>(new int[]{0});
			Array<int> len = new Array<int>(new int[]{this.nBuckets});
			object __temp_stmt25 = default(object);
			{
				haxe.lang.Function __temp_odecl23 = new Fun_48ca2127<T>(i, len, _g1);
				haxe.lang.Function __temp_odecl24 = new Fun_86405120<T>(_g1, i);
				__temp_stmt25 = new haxe.lang.DynamicObject(new Array<int>(new int[]{407283053, 1224901875}), new Array<object>(new object[]{__temp_odecl23, __temp_odecl24}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
			}
			
			return __temp_stmt25;
		}
	}
	
	
	public virtual   object keys()
	{
		unchecked 
		{
			Array<object> _g1 = new Array<object>(new object[]{this});
			Array<int> i = new Array<int>(new int[]{0});
			Array<int> len = new Array<int>(new int[]{this.nBuckets});
			object __temp_stmt28 = default(object);
			{
				haxe.lang.Function __temp_odecl26 = new Fun_e749be79<T>(i, len, _g1);
				haxe.lang.Function __temp_odecl27 = new Fun_64ddea98<T>(_g1, i);
				__temp_stmt28 = new haxe.lang.DynamicObject(new Array<int>(new int[]{407283053, 1224901875}), new Array<object>(new object[]{__temp_odecl26, __temp_odecl27}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
			}
			
			return __temp_stmt28;
		}
	}
	
	
	public virtual   bool @remove(string key)
	{
		unchecked 
		{
			int idx = -1;
			if ( ! ((( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) ))) ) 
			{
				idx = this.lookup(key);
			}
			
			if (( idx == -1 )) 
			{
				return false;
			}
			 else 
			{
				if (string.Equals(this.cachedKey, key)) 
				{
					this.cachedIndex = -1;
				}
				
				this.hashes[idx] = 0;
				this._keys[idx] = default(string);
				this.vals[idx] = default(T);
				 -- this.size;
				return true;
			}
			
		}
	}
	
	
	public virtual   bool exists(string key)
	{
		unchecked 
		{
			int idx = -1;
			if (( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) )) 
			{
				return true;
			}
			
			idx = this.lookup(key);
			if (( idx != -1 )) 
			{
				this.cachedKey = key;
				this.cachedIndex = idx;
				return true;
			}
			
			return false;
		}
	}
	
	
	public virtual   T getDefault(string key, T def)
	{
		unchecked 
		{
			int idx = -1;
			if (( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) )) 
			{
				return this.vals[idx];
			}
			
			idx = this.lookup(key);
			if (( idx != -1 )) 
			{
				this.cachedKey = key;
				this.cachedIndex = idx;
				return this.vals[idx];
			}
			
			return def;
		}
	}
	
	
	public virtual   haxe.lang.Null<T> @get(string key)
	{
		unchecked 
		{
			int idx = -1;
			if (( string.Equals(this.cachedKey, key) && ( (idx = this.cachedIndex) != -1 ) )) 
			{
				return new haxe.lang.Null<T>(this.vals[idx], true);
			}
			
			idx = this.lookup(key);
			if (( idx != -1 )) 
			{
				this.cachedKey = key;
				this.cachedIndex = idx;
				return new haxe.lang.Null<T>(this.vals[idx], true);
			}
			
			return default(haxe.lang.Null<T>);
		}
	}
	
	
	public   void resize(int newNBuckets)
	{
		unchecked 
		{
			int[] newHash = default(int[]);
			int j = 1;
			{
				{
					int x = newNBuckets;
					 -- x;
					x |= ((int) (( ((uint) (x) ) >> 1 )) );
					x |= ((int) (( ((uint) (x) ) >> 2 )) );
					x |= ((int) (( ((uint) (x) ) >> 4 )) );
					x |= ((int) (( ((uint) (x) ) >> 8 )) );
					x |= ((int) (( ((uint) (x) ) >> 16 )) );
					newNBuckets =  ++ x;
				}
				
				if (( newNBuckets < 4 )) 
				{
					newNBuckets = 4;
				}
				
				if (( this.size >= ( ( newNBuckets * 0.77 ) + 0.5 ) )) 
				{
					j = 0;
				}
				 else 
				{
					int nfSize = newNBuckets;
					newHash = new int[nfSize];
					if (( this.nBuckets < newNBuckets )) 
					{
						string[] k = new string[newNBuckets];
						if (( this._keys != default(string[]) )) 
						{
							System.Array.Copy(this._keys, 0, k, 0, this.nBuckets);
						}
						
						this._keys = k;
						T[] v = new T[newNBuckets];
						if (( this.vals != default(T[]) )) 
						{
							System.Array.Copy(this.vals, 0, v, 0, this.nBuckets);
						}
						
						this.vals = v;
					}
					
				}
				
			}
			
			if (( j != 0 )) 
			{
				this.cachedKey = default(string);
				this.cachedIndex = -1;
				j = -1;
				int nBuckets = this.nBuckets;
				string[] _keys = this._keys;
				T[] vals = this.vals;
				int[] hashes = this.hashes;
				int newMask = ( newNBuckets - 1 );
				while ((  ++ j < nBuckets ))
				{
					int k1;
					if ( ! ((( (( (k1 = hashes[j]) & -2 )) == 0 ))) ) 
					{
						string key = _keys[j];
						T val = vals[j];
						hashes[j] = 1;
						while (true)
						{
							int nProbes = 0;
							int i = ( k1 & newMask );
							while ( ! ((( newHash[i] == 0 ))) )
							{
								i = ( ( i +  ++ nProbes ) & newMask );
							}
							
							newHash[i] = k1;
							if (( ( i < nBuckets ) &&  ! ((( (( (k1 = hashes[i]) & -2 )) == 0 )))  )) 
							{
								{
									string tmp = _keys[i];
									_keys[i] = key;
									key = tmp;
								}
								
								{
									T tmp1 = vals[i];
									vals[i] = val;
									val = tmp1;
								}
								
								hashes[i] = 1;
							}
							 else 
							{
								_keys[i] = key;
								vals[i] = val;
								break;
							}
							
						}
						
					}
					
				}
				
				if (( nBuckets > newNBuckets )) 
				{
					{
						string[] k2 = new string[newNBuckets];
						System.Array.Copy(_keys, 0, k2, 0, newNBuckets);
						this._keys = k2;
					}
					
					{
						T[] v1 = new T[newNBuckets];
						System.Array.Copy(vals, 0, v1, 0, newNBuckets);
						this.vals = v1;
					}
					
				}
				
				this.hashes = newHash;
				this.nBuckets = newNBuckets;
				this.nOccupied = this.size;
				this.upperBound = ((int) (( ( newNBuckets * 0.77 ) + .5 )) );
			}
			
		}
	}
	
	
	public   int lookup(string key)
	{
		unchecked 
		{
			if (( this.nBuckets != 0 )) 
			{
				int[] hashes = this.hashes;
				string[] keys = this._keys;
				int mask = ( this.nBuckets - 1 );
				int hash = default(int);
				{
					int k = key.GetHashCode();
					k = ( ( k + 2127912214 ) + (( k << 12 )) );
					k = ( ( k ^ -949894596 ) ^ ( k >> 19 ) );
					k = ( ( k + 374761393 ) + (( k << 5 )) );
					k = ( ( k + -744332180 ) ^ ( k << 9 ) );
					k = ( ( k + -42973499 ) + (( k << 3 )) );
					k = ( ( k ^ -1252372727 ) ^ ( k >> 16 ) );
					int ret = k;
					if (( (( ret & -2 )) == 0 )) 
					{
						if (( ret == 0 )) 
						{
							ret = 2;
						}
						 else 
						{
							ret = -1;
						}
						
					}
					
					hash = ret;
				}
				
				int k1 = hash;
				int nProbes = 0;
				int i = ( k1 & mask );
				int last = i;
				int flag;
				while ((  ! ((( (flag = hashes[i]) == 0 )))  && (( ( ( flag == 1 ) || ( flag != k1 ) ) ||  ! (string.Equals(keys[i], key))  )) ))
				{
					i = ( ( i +  ++ nProbes ) & mask );
				}
				
				return ( (( (( flag & -2 )) == 0 )) ? (-1) : (i) );
			}
			
			return -1;
		}
	}
	
	
	public virtual   void @set(string key, T @value)
	{
		unchecked 
		{
			int x;
			int k;
			if (( this.nOccupied >= this.upperBound )) 
			{
				if (( this.nBuckets > ( this.size << 1 ) )) 
				{
					this.resize(( this.nBuckets - 1 ));
				}
				 else 
				{
					this.resize(( this.nBuckets + 2 ));
				}
				
			}
			
			int[] hashes = this.hashes;
			string[] keys = this._keys;
			int[] hashes1 = hashes;
			{
				int mask = ( (( this.nBuckets == 0 )) ? (0) : (( this.nBuckets - 1 )) );
				int site = x = this.nBuckets;
				{
					int k1 = key.GetHashCode();
					k1 = ( ( k1 + 2127912214 ) + (( k1 << 12 )) );
					k1 = ( ( k1 ^ -949894596 ) ^ ( k1 >> 19 ) );
					k1 = ( ( k1 + 374761393 ) + (( k1 << 5 )) );
					k1 = ( ( k1 + -744332180 ) ^ ( k1 << 9 ) );
					k1 = ( ( k1 + -42973499 ) + (( k1 << 3 )) );
					k1 = ( ( k1 ^ -1252372727 ) ^ ( k1 >> 16 ) );
					int ret = k1;
					if (( (( ret & -2 )) == 0 )) 
					{
						if (( ret == 0 )) 
						{
							ret = 2;
						}
						 else 
						{
							ret = -1;
						}
						
					}
					
					k = ret;
				}
				
				int i = ( k & mask );
				int nProbes = 0;
				if (( (( hashes1[i] & -2 )) == 0 )) 
				{
					x = i;
				}
				 else 
				{
					int last = i;
					int flag;
					while ( ! ((( ( (( (flag = hashes1[i]) & -2 )) == 0 ) || ( ( flag == k ) && string.Equals(this._keys[i], key) ) ))) )
					{
						i = ( ( i +  ++ nProbes ) & mask );
					}
					
					x = i;
				}
				
			}
			
			int flag1 = hashes1[x];
			if (( flag1 == 0 )) 
			{
				keys[x] = key;
				this.vals[x] = @value;
				hashes1[x] = k;
				this.size++;
				this.nOccupied++;
			}
			 else 
			{
				if (( flag1 == 1 )) 
				{
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
				}
				 else 
				{
					this.vals[x] = @value;
				}
				
			}
			
			this.cachedIndex = x;
			this.cachedKey = key;
		}
	}
	
	
	public  int cachedIndex;
	
	public  string cachedKey;
	
	public  int upperBound;
	
	public  int nOccupied;
	
	public  int size;
	
	public  int nBuckets;
	
	public  T[] vals;
	
	public  string[] _keys;
	
	public  int[] hashes;
	
	public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 1537812987:
				{
					return this.nBuckets = ((int) (@value) );
				}
				
				
				case 1280549057:
				{
					return this.size = ((int) (@value) );
				}
				
				
				case 480756972:
				{
					return this.nOccupied = ((int) (@value) );
				}
				
				
				case 2022294396:
				{
					return this.upperBound = ((int) (@value) );
				}
				
				
				case 922671056:
				{
					return this.cachedIndex = ((int) (@value) );
				}
				
				
				default:
				{
					return base.__hx_setField_f(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 995006396:
				{
					return this.hashes = ((int[]) (@value) );
				}
				
				
				case 2048392659:
				{
					return this._keys = ((string[]) (@value) );
				}
				
				
				case 1313416818:
				{
					return this.vals = ((T[]) (@value) );
				}
				
				
				case 1537812987:
				{
					return this.nBuckets = haxe.lang.Runtime.toInt(@value);
				}
				
				
				case 1280549057:
				{
					return this.size = haxe.lang.Runtime.toInt(@value);
				}
				
				
				case 480756972:
				{
					return this.nOccupied = haxe.lang.Runtime.toInt(@value);
				}
				
				
				case 2022294396:
				{
					return this.upperBound = haxe.lang.Runtime.toInt(@value);
				}
				
				
				case 1395555037:
				{
					return this.cachedKey = haxe.lang.Runtime.toString(@value);
				}
				
				
				case 922671056:
				{
					return this.cachedIndex = haxe.lang.Runtime.toInt(@value);
				}
				
				
				default:
				{
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 995006396:
				{
					return this.hashes;
				}
				
				
				case 2048392659:
				{
					return this._keys;
				}
				
				
				case 1313416818:
				{
					return this.vals;
				}
				
				
				case 1537812987:
				{
					return this.nBuckets;
				}
				
				
				case 1280549057:
				{
					return this.size;
				}
				
				
				case 480756972:
				{
					return this.nOccupied;
				}
				
				
				case 2022294396:
				{
					return this.upperBound;
				}
				
				
				case 1395555037:
				{
					return this.cachedKey;
				}
				
				
				case 922671056:
				{
					return this.cachedIndex;
				}
				
				
				case 5741474:
				{
					return new haxe.lang.Closure(this, "set", 5741474);
				}
				
				
				case 1639293562:
				{
					return new haxe.lang.Closure(this, "lookup", 1639293562);
				}
				
				
				case 142301684:
				{
					return new haxe.lang.Closure(this, "resize", 142301684);
				}
				
				
				case 5144726:
				{
					return new haxe.lang.Closure(this, "get", 5144726);
				}
				
				
				case 1797611211:
				{
					return new haxe.lang.Closure(this, "getDefault", 1797611211);
				}
				
				
				case 1071652316:
				{
					return new haxe.lang.Closure(this, "exists", 1071652316);
				}
				
				
				case 76061764:
				{
					return new haxe.lang.Closure(this, "remove", 76061764);
				}
				
				
				case 1191633396:
				{
					return new haxe.lang.Closure(this, "keys", 1191633396);
				}
				
				
				case 328878574:
				{
					return new haxe.lang.Closure(this, "iterator", 328878574);
				}
				
				
				case 946786476:
				{
					return new haxe.lang.Closure(this, "toString", 946786476);
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 1537812987:
				{
					return this.nBuckets;
				}
				
				
				case 1280549057:
				{
					return this.size;
				}
				
				
				case 480756972:
				{
					return this.nOccupied;
				}
				
				
				case 2022294396:
				{
					return this.upperBound;
				}
				
				
				case 922671056:
				{
					return this.cachedIndex;
				}
				
				
				default:
				{
					return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_invokeField(string field, int hash, Array dynargs)
	{
		unchecked 
		{
			switch (hash)
			{
				case 5741474:
				{
					this.@set(haxe.lang.Runtime.toString(dynargs[0]), haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					return default(object);
				}
				
				
				case 1639293562:
				{
					return this.lookup(haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 142301684:
				{
					this.resize(haxe.lang.Runtime.toInt(dynargs[0]));
					return default(object);
				}
				
				
				case 5144726:
				{
					return (this.@get(haxe.lang.Runtime.toString(dynargs[0]))).toDynamic();
				}
				
				
				case 1797611211:
				{
					return this.getDefault(haxe.lang.Runtime.toString(dynargs[0]), haxe.lang.Runtime.genericCast<T>(dynargs[1]));
				}
				
				
				case 1071652316:
				{
					return this.exists(haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 76061764:
				{
					return this.@remove(haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 1191633396:
				{
					return this.keys();
				}
				
				
				case 328878574:
				{
					return this.iterator();
				}
				
				
				case 946786476:
				{
					return this.toString();
				}
				
				
				default:
				{
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
		}
	}
	
	
	public override   void __hx_getFields(Array<object> baseArr)
	{
		unchecked 
		{
			baseArr.push("hashes");
			baseArr.push("_keys");
			baseArr.push("vals");
			baseArr.push("nBuckets");
			baseArr.push("size");
			baseArr.push("nOccupied");
			baseArr.push("upperBound");
			baseArr.push("cachedKey");
			baseArr.push("cachedIndex");
			{
				base.__hx_getFields(baseArr);
			}
			
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}



public  class Fun_48ca2127<T> : haxe.lang.Function 
{
	public    Fun_48ca2127(Array<int> i, Array<int> len, Array<object> _g1) : base(0, 0)
	{
		unchecked 
		{
			this.i = i;
			this.len = len;
			this._g1 = _g1;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			{
				int _g = this.i[0];
				while (( _g < this.len[0] ))
				{
					int j = _g++;
					if ( ! ((( (( ((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) ).hashes[j] & -2 )) == 0 ))) ) 
					{
						this.i[0] = j;
						return true;
					}
					
				}
				
			}
			
			return false;
		}
	}
	
	
	public  Array<int> i;
	
	public  Array<int> len;
	
	public  Array<object> _g1;
	
}



public  class Fun_86405120<T> : haxe.lang.Function 
{
	public    Fun_86405120(Array<object> _g1, Array<int> i) : base(0, 0)
	{
		unchecked 
		{
			this._g1 = _g1;
			this.i = i;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			T ret = ((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) ).vals[this.i[0]];
			this.i[0] = ( this.i[0] + 1 );
			return ret;
		}
	}
	
	
	public  Array<object> _g1;
	
	public  Array<int> i;
	
}



public  class Fun_e749be79<T> : haxe.lang.Function 
{
	public    Fun_e749be79(Array<int> i, Array<int> len, Array<object> _g1) : base(0, 0)
	{
		unchecked 
		{
			this.i = i;
			this.len = len;
			this._g1 = _g1;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			{
				int _g = this.i[0];
				while (( _g < this.len[0] ))
				{
					int j = _g++;
					if ( ! ((( (( ((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) ).hashes[j] & -2 )) == 0 ))) ) 
					{
						this.i[0] = j;
						return true;
					}
					
				}
				
			}
			
			return false;
		}
	}
	
	
	public  Array<int> i;
	
	public  Array<int> len;
	
	public  Array<object> _g1;
	
}



public  class Fun_64ddea98<T> : haxe.lang.Function 
{
	public    Fun_64ddea98(Array<object> _g1, Array<int> i) : base(0, 0)
	{
		unchecked 
		{
			this._g1 = _g1;
			this.i = i;
		}
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			string ret = ((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) )._keys[this.i[0]];
			((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) ).cachedIndex = this.i[0];
			((Hash<T>) (((Hash) (this._g1[0]) ).cast<T>()) ).cachedKey = ret;
			this.i[0] = ( this.i[0] + 1 );
			return ret;
		}
	}
	
	
	public  Array<object> _g1;
	
	public  Array<int> i;
	
}



public  interface Hash : haxe.lang.IHxObject, haxe.lang.IGenericObject 
{
	   object cast<T1>();
	
}


