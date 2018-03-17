## C# ch9 Homework  
#### author: nick terry  
#### date: mar 17, 2018  


1. enum Ranks {PVT, PV2, PFC, SPC, SGT, ... GEN};  

2. Rank terry = Ranks.SGT  

3. terry = 4  

4. You can select the underlying type of enum by specifying it after :.  
For example - enum Ranks : short { PVT, PV2, ...} would give the underlying values a short value instead of the integer. It would still start at 0 and go up in this example.  

5. Structs are stored on the stack. Enums are stored on the heap.  

6. struct DOD  
{  
	string army, navy, airforce, marines;  
}  

7. You cant make a default struct because the compiler always creates its own.  

8. CIL is Common Intermediate Language. CLR takes the CIL and converts it into machine language that the computer can understand.