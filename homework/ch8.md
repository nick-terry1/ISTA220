## C# HW Ch 8  
#### author: nick terry  
#### date: mar 8, 2018  

1. The difference between deep copy and shallow copy is when referring to a clone method that copies a class whose 
data is just a reference, a deep copy needs a the reference type to also provide a clone method to copy the data, whereas 
a shallow copy just copies the reference.  

2. The value of a reference after you declare and initialize it is whatever the value initialized is.  

3. you declare a variable type by giving it a primitive type.  

4. You declare a reference type by creating a new instance of an object.  

5. You cant assign null to a value type unless its a nullable value type.  

6. A nullable value type can hold all values of a value type but not the other way around because value types cant hold the value null.  

7. The difference between the stack and the heap is that the stack is more local and the memory space clears as soon as the the method or curly 
brace ends. The heap is where the memory space for classes come from and it only clears when all the references to it disappear.  

8. When you say all classes are specialized types it means classes can refer to any reference type.  

9. Ref passes the reference to the actual argument as opposed to just a copy so any changes that occur to the parameter also happens to the original argument.  

10. Out is the same as ref in that the parameter and the original argument are linked, however out lets you initialize the original argument by initializing the parameter.  

11. Boxing is where an object refers to a variable but all references must refer to the heap (the variable is stored on the stack) therefore the program creates a copy, puts it on the heap, 
and refers to that instead. Unboxing is the opposite where you use a variable to access the copied variable through the use of casting.  

12. Casting is prefixing the object variable with a type so the program knows what type it is retrieving. like (int)Object.