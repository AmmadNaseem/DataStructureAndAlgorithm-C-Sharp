# DataStructureAndAlgorithm-C-Sharp
1.Abstract Data Type: everybody has a different definition, but a class/ object. "respresentation & Operation". List, Linked-ListQueue,etc. Think "data do things with data". "Defined but not implemented". Book vs Telephonebook.

2.Big-o Notation:Time Complexity of algorithm. How efficient your code? 
	a.Horrible : O(n!), O(2^n), O(n^2),
	b.Bad: O(n log n)
	c.Fair: O(n)
	d.Good: O(log n)
	e.Excellent: O(1)

3. Excellent: O(1)-"Constant": O(1) slang for constant.Time complexity flat.
	->Assignment var test-0;
	->Declarations var test;
	->Comparison 2>1;
	->Arthmetic 2+2;
	->Acccessing Element array[1];
	->Calling Function soneFunction();

4.Fair: O(n)-"Linear": O(N) slang for linear. time complexity linearly slop.
	->Think "for loop"
	->Number of inputs increase time
	->int total=0 -------- O(1)
	->while(i<=10) -------O(N)
	->Take the bigger number
	->e.g.
		int total=0; 
		int i=2;
		while(i<=10){
			total total + i;
			 i=i+1;
		}

5.Horrible: O(N^2)-"Quadratic": Nested for loop- "Brute Force": Time complexity of alogrithm quardatic is not good.
var n= int.Parse(Console.ReadLine());
for(var r=1;r<=n;r++)
{
	for(var c=1;c<=n;c++)
	{
		Console.Write("*");
	}
Console.WriteLine();
}

6.Good: O(Log N)-"Binary Search and Trees."

7.Bad: O(N Log (n))-"Quick Sort, Merge Sort, Shell Sort, Cube Sort".


=================================================Arrays=========================================
1.Array: it is in contigious places in the memory. Arrays contain anything, fixed size, random access,Killer Feature? GET SET, AKA "Random Access", Think "Hard Drive vs. RAM" e.g. like park bench anology fixed size. Manuplation adn insertion in array are two different things. updation: arra[6]="ammad naseem"

2.Lists<> are actually arrays
3. Array insertion and deletion: insert at start/anywhere/end. delete from end/start/anywhere.
4. INSERTION IN ARRAY:
 static void Main(string[] args)
        {
            //Stack ts = new Stack();

            //Pokemon squirtle = new Pokemon();

            //INSERTING AT THE START OF AN ARRAY
            int[] intArray = new int[6];
            //MAKE A VARIABLE TO KEEP THE LENGTH BECAUSE LENGTH IS BASED OFF CAPACITY AND DOES TRACK THE ACTUAL INDEX
            int length = 0;

            //THIS ADD DATA FOR US
            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            //==INSERTING ANYWHERE OF ARRAY= WE WNA TO PUT VALUT AT PLCE 2
            for (int i = 4; i >=2 ; i--)
            {
                //shifiting each element from one positon to the right
                intArray[i + 1] = intArray[i];

            }
            intArray[2] = 8;
                

            ////Ading start of an array.
            //for (int i = 3; i>=0 ; i--)
            //{
            //    intArray[i + 1] = i;
            //}
            //intArray[0] = 10;

            ////INSERTING AT THE END OF AN ARRAY
            //int[] intArray = new int[6];
            ////MAKE A VARIABLE TO KEEP THE LENGTH BECAUSE LENGTH IS BASED OFF CAPACITY AND DOES TRACK THE ACTUAL INDEX
            //int length = 0;

            ////THIS ADD DATA FOR US
            //for (int i = 0; i < 3; i++)
            //{
            //    intArray[length] = i+1;
            //    length++;   
            //}
            //intArray[length] = 8;
            //length++;
        }
    }

5.DELETION IN ARRAY:
  static void Main(string[] args)
        {
            //=========ARRAY DELETION 
            int[] intArray = new int[9];
            int length = 0;
            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;
            }
            //=========delete at End of array';
            //length--;

            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            //===============delete from start=============
            //for (int i = 1; i < length; i++)
            //{
            //    intArray[i - 1] = intArray[i];
            //}
            //length--;

            //================delete from anywhere=============
            //let delete number 3.
            for (int i = 5; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;


            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

6.LINKED LIST:Ancestor of the List<>, the most important in c#.Liked list is any array that can be objectify.This is not used in today software development.Good thing about linked list we can insert anywhere and it is dynamic while array has a fixed size.
-> Node: nodes have the two parts: 1.Actual data 2.reference data that point the next node.

7.STACK: Think "a tube of tennis ball"- Last In First Out.
	->push: put data in container is push like put tennius bal in box.
	->pop: is getting ball from the box.
	->peek:is the top bal at the box show.it is getting the very top value.
	->top: latest  value in stack is top.keep track of latest value in memory.
	->TIME COMPLEXITY: it is depend upon which data structure we used. Linked list implementation is ideal because 					insertions/deletions are O(1). while in array inseriton and deletion is O(N).

8.QUEUE:First In First Out:
	->add(enqueue) :add item to the END.
	->remove(dequeue) : remove item at the FRONT.
	->peek:

9.BINARY SEARCH:we can only search sorted data like the phone book algorithm.
	PSEUDO CODE:
	-> fibnd middle element
	->Is the middle element?Yes?Done.
	->Is it bigger? Search the left half.
	->Is it smaller Search the right half.
	->Keep "Halfing" till you find the number

	Algo: search value:2
		start:0; End=5; 
		Mid=(start+end)/2=3

10.STATIC CLASS:
A public static class in C# allows you to define a class that contains only static members and cannot be instantiated. It is a convenient way to group related methods and functions together that don't need to access or modify instance-level data.

By defining a class as static, you do not need to create an instance of the class to access its methods and properties, which can save memory and reduce the amount of code required. You can simply call the method or property on the class itself, without needing an instance.

In addition, a public static class can be accessed from anywhere within your application, which makes it easy to share common functionality across multiple classes or modules. This can promote code reusability and reduce the amount of code duplication in your application.

11.BINARY Search TREES: Searchable, non-linear linked list.
	->A tree is hierarchical Data structure, nodes, parent, children(Only 2), root and sorted.
	->RULES FOR A BINARY SEARCH TREE:
		1. only have two nodes per parent.
		2.Every node to the left is less
		3.Every node to the right of parent is greater.

12.RECUSION: A function that calls itself. it work on stack overflow.
	-> main function is the first function that go on the stack.
	->execute function is push of the stack.
	->returned from the stack is pop of the stack.
	-> each stack has own state of variable.

13.Two ways of trees traveral:
	1.Breadth First Search:it is a level order.it is a un-common algorithm.
	2.Depth First Search:it have three other types of traversal techniques.

14. Depth First Traversal: 
	->Level: visit nodes on each level
	1.Pre-Order: Visit root of every subtree first.******(Node,L,R). ===top to bootom moving
	2.Post-Order: Visit the root of every subtrees last.******(L,R,Node). ===bottom to top moving.
	3.In-Order: Visit left child, then root, then right child.******(L,Node,R). ===Left to Right Moving

15. Hash Tables: one of the most useful algorithms in programming.
	->Hash table is a simple concept it just an array with key-value pairs.
	->Similar to arrays but unordered. we are not going to sort them.
	->Hash Tables are fast for everthings.(find,add,remove).
	->Disadvantages? Collisions and Load Factor.

16.why use Hash Table over array?
	->Through this we can grap data through the actual name while in array get through index.
	->pokedex # => pokemon , 3 => charmander
	->WHAT ARE HASH TABLE CALLED IN C#?
		->Dictionary <TKey,TValue> :it is the actual data structure it build on top of hash table.
		->Hash Table (Non-generic & Tread Safe)
		->KeyValuePair<>(Element) : key value pair are the elements in hash table.
	->Sometimes called ASSOCIATIVE ARRAY!

17.WHY IS IT A HASH? Hah can't be reversed engineered.
	->Uses a hash function
	->Convert array values into key
	->MUST BE constant time
	->Deterministic (Same output yields same input)
	->THINK "ADDRESS LOCATER"

18.SET:
	->Accept a key and value
	->Hash they key
	->Store the key-value pair in the hash table array via Seperate Chaining.

