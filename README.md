# DataStructureAndAlgorithm-C-Sharp
1.Abstract Data Type: everybody has a different definition, but a class/ object. "respresentation & Operation". List, Linked-ListQueue,etc. Think "data do things with data". "Defined but not implemented". Book vs Telephonebook.<br>

2.Big-o Notation:Time Complexity of algorithm. How efficient your code? <br>
	a.Horrible : O(n!), O(2^n), O(n^2),<br><br>
	b.Bad: O(n log n)<br>
	c.Fair: O(n)<br>
	d.Good: O(log n)<br><br>
	e.Excellent: O(1)<br>

3. Excellent: O(1)-"Constant": O(1) slang for constant.Time complexity flat.<br>
	->Assignment var test-0;<br>
	->Declarations var test;<br>
	->Comparison 2>1;<br>
	->Arthmetic 2+2;<br>
	->Acccessing Element array[1];<br>
	->Calling Function soneFunction();<br>

4.Fair: O(n)-"Linear": O(N) slang for linear. time complexity linearly slop.<br>
	->Think "for loop"<br>
	->Number of inputs increase time<br>
	->int total=0 -------- O(1)<br>
	->while(i<=10) -------O(N)<br>
	->Take the bigger number<br>
	->e.g.<br>
		int total=0; <br>
		int i=2;<br>
		while(i<=10){<br>
			total total + i;<br>
			 i=i+1;<br>
		}<br>

5.Horrible: O(N^2)-"Quadratic": Nested for loop- "Brute Force": Time complexity of alogrithm quardatic is not good.<br>
var n= int.Parse(Console.ReadLine());<br>
for(var r=1;r<=n;r++)<br>
{<br>
	for(var c=1;c<=n;c++)<br>
	{<br>
		Console.Write("*");<br>
	}<br>
Console.WriteLine();<br>
}<br>

6.Good: O(Log N)-"Binary Search and Trees."<br>

7.Bad: O(N Log (n))-"Quick Sort, Merge Sort, Shell Sort, Cube Sort".<br>


=================================================Arrays=========================================
1.Array: it is in contigious places in the memory. Arrays contain anything, fixed size, random access,Killer Feature? GET SET, AKA "Random Access", Think "Hard Drive vs. RAM" e.g. like park bench anology fixed size. Manuplation adn insertion in array are two different things. updation: arra[6]="ammad naseem"<br>

2.Lists<> are actually arrays<br><br>
3. Array insertion and deletion: insert at start/anywhere/end. delete from end/start/anywhere.<br>
4. INSERTION IN ARRAY:<br>
 static void Main(string[] args)<br>
        {<br>
            //Stack ts = new Stack();<br>

            //Pokemon squirtle = new Pokemon();<br>
<br>
            //INSERTING AT THE START OF AN ARRAY<br>
            int[] intArray = new int[6];<br>
            //MAKE A VARIABLE TO KEEP THE LENGTH BECAUSE LENGTH IS BASED OFF CAPACITY AND DOES TRACK THE ACTUAL INDEX<br>
            int length = 0;<br>

            //THIS ADD DATA FOR US<br>
            for (int i = 0; i < 3; i++)<br>
            {<br>
                intArray[length] = i + 1;<br>
                length++;<br>
            }<br>

            //==INSERTING ANYWHERE OF ARRAY= WE WNA TO PUT VALUT AT PLCE 2<br>
            for (int i = 4; i >=2 ; i--)<br>
            {<br>
                //shifiting each element from one positon to the right<br>
                intArray[i + 1] = intArray[i];<br>

            }<br>
            intArray[2] = 8;<br>
                

            ////Ading start of an array.<br>
            //for (int i = 3; i>=0 ; i--)<br>
            //{<br>
            //    intArray[i + 1] = i;<br>
            //}<br>
            //intArray[0] = 10;<br>

            ////INSERTING AT THE END OF AN ARRAY<br>
            //int[] intArray = new int[6];<br>
            ////MAKE A VARIABLE TO KEEP THE LENGTH BECAUSE LENGTH IS BASED OFF CAPACITY AND DOES TRACK THE ACTUAL INDEX<br>
            //int length = 0;<br>
<br>
            ////THIS ADD DATA FOR US
            //for (int i = 0; i < 3; i++)<br>
            //{<br>
            //    intArray[length] = i+1;<br>
            //    length++;   <br>
            //}<br>
            //intArray[length] = 8;<br>
            //length++;<br>
        }<br>
    }<br>

5.DELETION IN ARRAY:<br>
  static void Main(string[] args)<br><br><br><br><br><br><br>
        {<br><br><br><br><br><br><br>
            //=========ARRAY DELETION <br><br><br><br><br><br><br>
            int[] intArray = new int[9];<br><br><br><br><br><br><br>
            int length = 0;<br><br><br><br><br><br><br>
            for (int i = 0; i < 6; i++)<br><br><br><br><br><br><br>
            {<br><br><br><br><br><br><br>
                intArray[length] = i;<br><br><br><br><br><br><br>
                length++;<br><br><br><br><br><br><br>
            }<br><br><br><br><br><br><br>
            //=========delete at End of array';<br><br><br><br><br><br><br>
            //length--;<br><br><br><br><br><br><br>

            //for (int i = 0; i < length; i++)<br><br><br><br><br><br><br>
            //{<br><br><br><br><br><br><br>
            //    Console.WriteLine(intArray[i]);<br><br><br><br><br><br><br>
            //}<br><br><br><br><br><br><br>

            //===============delete from start=============<br><br><br><br><br><br><br>
            //for (int i = 1; i < length; i++)<br><br><br><br><br><br><br>
            //{<br><br><br><br><br><br><br>
            //    intArray[i - 1] = intArray[i];<br><br><br><br><br><br><br>
            //}<br><br><br><br><br><br><br>
            //length--;<br><br><br><br><br><br><br>

            //================delete from anywhere=============<br><br><br><br><br><br><br>
            //let delete number 3.<br><br><br><br><br><br><br>
            for (int i = 5; i < length; i++)<br><br><br><br><br><br><br>
            {<br><br><br><br><br><br><br>
                intArray[i - 1] = intArray[i];<br><br><br><br><br><br><br>
            }<br><br><br><br><br><br><br>
            length--;<br><br><br><br><br><br><br>

<br><br><br><br><br><br><br>
            for (int i = 0; i < length; i++)<br><br><br><br><br><br><br>
            {<br><br><br><br><br><br><br>
                Console.WriteLine(intArray[i]);<br><br><br><br><br><br><br>
            }<br><br><br><br><br><br><br>
<br><br><br><br><br><br><br>
6.LINKED LIST:Ancestor of the List<>, the most important in c#.Liked list is any array that can be objectify.This is not used in today software development.Good thing about linked list we can insert anywhere and it is dynamic while array has a fixed size.<br><br><br><br><br><br><br>
-> Node: nodes have the two parts: 1.Actual data 2.reference data that point the next node.<br><br><br><br><br><br><br>

7.STACK: Think "a tube of tennis ball"- Last In First Out.<br><br><br><br><br><br><br>
	->push: put data in container is push like put tennius bal in box.<br><br><br><br><br><br><br>
	->pop: is getting ball from the box.<br><br><br><br><br><br><br>
	->peek:is the top bal at the box show.it is getting the very top value.<br><br><br><br><br><br><br>
	->top: latest  value in stack is top.keep track of latest value in memory.<br><br><br><br><br><br><br>
	->TIME COMPLEXITY: it is depend upon which data structure we used. Linked list implementation is ideal because 	<br><br><br><br><br><br><br>				insertions/deletions are O(1). while in array inseriton and deletion is O(N).<br><br><br><br><br><br><br>
<br><br><br><br><br><br><br>
8.QUEUE:First In First Out:<br><br><br><br><br><br><br>
	->add(enqueue) :add item to the END.<br><br><br><br><br><br><br>
	->remove(dequeue) : remove item at the FRONT.<br><br><br><br><br><br><br>
	->peek:<br><br><br><br><br><br>

9.BINARY SEARCH:we can only search sorted data like the phone book algorithm.<br><br><br><br><br>
	PSEUDO CODE:<br><br><br><br><br>
	-> fibnd middle element<br><br><br><br><br>
	->Is the middle element?Yes?Done.<br><br><br><br><br>
	->Is it bigger? Search the left half.<br><br><br><br><br>
	->Is it smaller Search the right half.<br><br><br><br><br>
	->Keep "Halfing" till you find the number<br><br><br><br><br>

	Algo: search value:2<br><br><br><br><br>
		start:0; End=5; <br><br><br><br><br>
		Mid=(start+end)/2=3<br><br><br><br><br>

10.STATIC CLASS:<br><br><br><br><br>
A public static class in C# allows you to define a class that contains only static members and cannot be instantiated. It is a convenient way to group related methods and functions together that don't need to access or modify instance-level data.<br><br><br><br><br>

By defining a class as static, you do not need to create an instance of the class to access its methods and properties, which can save memory and reduce the amount of code required. You can simply call the method or property on the class itself, without needing an instance.<br><br><br><br><br>

In addition, a public static class can be accessed from anywhere within your application, which makes it easy to share common functionality across multiple classes or modules. This can promote code reusability and reduce the amount of code duplication in your application.<br><br><br><br><br>

11.BINARY Search TREES: Searchable, non-linear linked list.<br><br><br><br><br>
	->A tree is hierarchical Data structure, nodes, parent, children(Only 2), root and sorted.<br><br><br><br><br>
	->RULES FOR A BINARY SEARCH TREE:<br><br><br><br><br>
		1. only have two nodes per parent.<br><br><br><br><br>
		2.Every node to the left is less<br><br><br><br><br>
		3.Every node to the right of parent is greater.<br><br><br><br><br>

12.RECUSION: A function that calls itself. it work on stack overflow.<br><br><br><br><br>
	-> main function is the first function that go on the stack.<br><br><br><br><br>
	->execute function is push of the stack.<br><br><br><br><br>
	->returned from the stack is pop of the stack.<br><br><br><br><br>
	-> each stack has own state of variable.<br><br><br><br><br>

13.Two ways of trees traveral:<br><br><br><br>
	1.Breadth First Search:it is a level order.it is a un-common algorithm.<br><br><br><br>
	2.Depth First Search:it have three other types of traversal techniques.<br><br><br><br>
<br><br><br><br>
14. Depth First Traversal: <br><br><br>
	->Level: visit nodes on each level<br><br><br>
	1.Pre-Order: Visit root of every subtree first.******(Node,L,R). ===top to bootom moving<br><br><br>
	2.Post-Order: Visit the root of every subtrees last.******(L,R,Node). ===bottom to top moving.<br><br><br>
	3.In-Order: Visit left child, then root, then right child.******(L,Node,R). ===Left to Right Moving<br><br><br>
<br><br><br>
15. Hash Tables: one of the most useful algorithms in programming.<br><br><br>
	->Hash table is a simple concept it just an array with key-value pairs.<br><br><br>
	->Similar to arrays but unordered. we are not going to sort them.<br><br><br>
	->Hash Tables are fast for everthings.(find,add,remove).<br><br><br>
	->Disadvantages? Collisions and Load Factor.<br><br><br>

16.why use Hash Table over array?<br><br><br>
	->Through this we can grap data through the actual name while in array get through index.<br><br><br>
	->pokedex # => pokemon , 3 => charmander<br><br>
	->WHAT ARE HASH TABLE CALLED IN C#?<br><br>
		->Dictionary <TKey,TValue> :it is the actual data structure it build on top of hash table.<br><br>
		->Hash Table (Non-generic & Tread Safe)<br><br>
		->KeyValuePair<>(Element) : key value pair are the elements in hash table.<br><br>
	->Sometimes called ASSOCIATIVE ARRAY!<br><br>

17.WHY IS IT A HASH? Hah can't be reversed engineered.<br><br>
	->Uses a hash function<br><br>
	->Convert array values into key<br><br>
	->MUST BE constant time<br><br>
	->Deterministic (Same output yields same input)<br><br>
	->THINK "ADDRESS LOCATER"<br><br>

18.SET:<br>
	->Accept a key and value<br>
	->Hash they key<br>
	->Store the key-value pair in the hash table array via Seperate Chaining.<br>

