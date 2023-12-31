# BOOTCAMP C# Formulatrix

## WEEK 1
> ### Day 1 - 31/07/2023 (Project 1)
- Set up
- Project structure
- Scratch Class Diagram untuk membuat variabel dan methods
- Class as a blueprint => object/instance
---
> ### Day 2 - 01/08/2023 (Project 2-5)
- Method with parameters inside
- Class ada variabel dan function/method

*__Function:__* <br>
```
public void myMethod()
```
- `public, private, protected, internal` => *_access modifier_*
- `void, int, string, bool` => *_return type_*
- `myMethod` => *_name_*
- `()` => *_parameter_*

*__About CONSTRUCTOR__ (Project 4)*
```
public class Lamp {
    public string? lampType;

    public Lamp(string LampType)
    {
	    this.lampType = LampType;
    }
}
```
- Special method untuk menginisialisasi object
- Constructors terpanggil saat object dibuat
- All classes have constructors by default, tapi tidak bisa set value
- Must match with the class name
- CanNOT have return type

*__4 PILAR OOP__*
- INHERITANCE (Project 5)
    - Constructor tidak bisa di-inherit, harus buat sendiri per class
---
> ### Day 3 - 02/08/2023 (Project 6-7)
- Default access modifier pada class adalah internal

*__4 PILAR OOP__*
- ***ENCAPSULATION*** (Project 6)
    - `Public` => every class
    - `Private` => local hanya untuk parent
    - `Protected` => child bisa access dari parent tsb
    - `Internal` => project ada dll dan exe
    - `Protected internal`
- ***POLYMORPHISM*** (Project 7) => 1 bentuk berlaku pada bentuk yg lain
    - OVERLOAD
        ```
        int Add(int x, int y)
        string Add(string x, string y)
        ```
    - OVERRIDE
        - Child (override) tidak perlu mengikuti parent (virtual)

**LATIHAN MANDIRI** <br>
Inheritance - Encap - Poly aku gabung jd satu => Stranger Things

---
> ### Day 4 - 03/08/2023 (Project 8-12)
*__4 PILAR OOP__*
- ***ABSTRACTION***
    - Class
        - Solid
        - Bisa dibuat instance
    - Abstract class
        - Solid + abstract
        - Tidak bisa dibuat instance
    - Interface
        - Full abstract
        - Tidak bisa dibuat instance
        - Bisa multiple inherit
        - Multiple interface di 1 class
        - Declare variabel dengan property/variable method
        - Anak interface => implement

**LATIHAN MANDIRI** <br>
- Interface CHECK
- Abstract CHECK
- Abstract interface (ada non abstract)
- Parent => child, begitu juga sebaliknya
---
> ### Day 5 - 04/08/2023 (Project 13-16)
***CASTING ADA 2 TIPE***
- Explicit (tipe data besar ke kecil) downcast
- Implicit (tipe data kecil ke besar) upcast

***PROSES BOXING***
- Membungkus data apapun menggunakan objek
- Class static tidak bisa dibuat instance

***PRINSIP DASAR PROGRAMMING***
- SOLID [Link penjelasan](https://kodebagus.medium.com/solid-principles-daf3282a4e70)
    - `Single Responsibility`
    - `Open Closed`
    - `Liskov Substitution`
    - `Interface Segregation`
    - `Dependency Inversion/Injention`
- DRY `Don't Repeat Yourself`
    - Semua bagian data hanya diproses di satu tempat
- KISS `Keep It Simple, Stupid`
    - Kode efisien dan sederhana


## WEEK 2
> ### Day 6 - 07/08/2023 (Project 18-)
- Review Upcast Downcast (Explicit Implicit)
- Pattern Matching (Project 18)
- Ref, In, Out (pass address as an argument)
    - Ref (Project 19)
        - Declare harus ada value nya
        - Yang dipassing address memory nya (pointer), bukan value
    - Out (Project 20)
        - Declare bisa kosongan
        - Passing kosongan, output harus ada value
        - Mengubah string ke int dengan `Parse`


```
string input = Console.ReadLine();
int x = int.Parse(input);
```


    - In (Project 21)
        - Tidak boleh diubah valuenya
        - Status read-only
- Value and Reference Type
    - String
        - Immutable
        - Pakai StringBuilder => append method (memori yg sama, tidak membuat memori baru) (Project 22)
- Const & read-only (Project 23)
    - Const
        - Static
        - Must assign value on variabel
    - Read-only
        - Dibuat instance
        - Empty variable, assign it via constructor
- Enum
- Generic
    - Bisa isi tipe data apapun tergantung user
---
> ### Day 7 - 08/08/2023
- Tipe2 class
    - Class concrete
    - Struct
    - Enum => data2 yg constant/collection of constant
    - Generic
    - Delegate
    - Abstract
    - Interface
- Delegate (pass method as an argument)<br>
``` public delegate void MyDel() ``` <br>
**Karakteristik *signature*** => method di dalamnya MUST HAVE THE SAME RETURN VALUE AND PARAMETER
    - Callback function
    - Publisher Subscriber (untuk notif)

- Tuple
---
> ### Day 8 - 09/08/2023
- Event: 
    - EventArgs.
    - tidak bisa = saja, bertambah sedikit2
- ExceptionHandler => try catch
- Parse, TryParse
---
> ### Day 9 - 10/08/2023
- Operator Overloading
- Enum => collection of constant data
- Try-Catch-Finally
- Enumerable (kendaraan) => return IEnumerator (mesin)
    - Object yg bisa di-iterasi
    - Bisa diterapkan di array/collection (list, dictionary)
    - Method `GetEnumerator` => bool MoveNext(), Reset()
    - Property `GetEnumerator` => Current
    - Bisa melakukan foreach
---
> ### Day 10 - 11/08/2023
- Substring => ngambil dari indeks awal ke indeks terakhir yg direquest
- ToUpper
- ToLower
- Trim => ngilangin seluruh spasi sebelum dan sesudah
- Replace => 
- Split
- Contains
- Convert
- DeadTime
- Equals Comparison => menggunakan address yg berisi value 
- FormatterParse

Value Type
    - int
    - double
    - decimal
    - long
    - char
    - double

Ref Type
    - Str
    - List
    - Class
    - Array
    - Object

---
## Week 3
> ### Day 11 - 14/08/2023
- Collection of multiple data YANG BISA DIUBAH, tidak seperti enum
    - Array
        - Fix size
        - Type safety
        - Index[]
    - ArrayList => multiple type of data
        - Dynamic size
        - NOT type safety (tipe data apapun bisa dicampur)
        - Index[]
    - List Generic<T>
        - Dynamic size
        - Type safety
        - Index[]
    - HashSet
        - Dynamic
        - Type safety
        - Unique, tidak ada data yg sama
    - LinkedList
        - Dynamic size
        - Type safety
        - Performance add/remove item in index
        - Data sangat bergantung pada index, maka menggunakan ini
        - Kekurangan: boros memori
- Dictionary
    - Safety
    - Dynamic
- Hashtable
    - Not safety
- SortedDictionary
    - Sort based on the key
    
> ### Day 12 - 15/08/2023
- Stack => LIFO, ada versi generic
    - Push()
    - Pop()
    - Peek()
    - Clone() => pada value type yg digandakan instance nya, ref type address nya
    - CopyTo() => tidak saling ketergantungan
- Queue => ada versi generic
    - Enqueue()
    - Dequeue()
    - Peek()
- Partial Class
    - Class & namespace yg sama, namun beda file
    - MUST have same access modifier
    - Berguna untuk game
- Sealed

> ### Day 13 - 16/08/2023
- Focus test one on one

> ### Day 14 - Day 15 (17/08/2023 - 18/08/2023)
- Libur 17an

## Week 4
> ### Day 16 - 21/08/2023
WFH

> ### Day 17 - 22/08/2023
# BOOTCAMP C# Formulatrix

## WEEK 1
> ### Day 1 - 31/07/2023 (Project 1)
- Set up
- Project structure
- Scratch Class Diagram untuk membuat variabel dan methods
- Class as a blueprint => object/instance
---
> ### Day 2 - 01/08/2023 (Project 2-5)
- Method with parameters inside
- Class ada variabel dan function/method

*__Function:__* <br>
```
public void myMethod()
```
- `public, private, protected, internal` => *_access modifier_*
- `void, int, string, bool` => *_return type_*
- `myMethod` => *_name_*
- `()` => *_parameter_*

*__About CONSTRUCTOR__ (Project 4)*
```
public class Lamp {
    public string? lampType;

    public Lamp(string LampType)
    {
	    this.lampType = LampType;
    }
}
```
- Special method untuk menginisialisasi object
- Constructors terpanggil saat object dibuat
- All classes have constructors by default, tapi tidak bisa set value
- Must match with the class name
- CanNOT have return type

*__4 PILAR OOP__*
- INHERITANCE (Project 5)
    - Constructor tidak bisa di-inherit, harus buat sendiri per class
---
> ### Day 3 - 02/08/2023 (Project 6-7)
- Default access modifier pada class adalah internal

*__4 PILAR OOP__*
- ***ENCAPSULATION*** (Project 6)
    - `Public` => every class
    - `Private` => local hanya untuk parent
    - `Protected` => child bisa access dari parent tsb
    - `Internal` => project ada dll dan exe
    - `Protected internal`
- ***POLYMORPHISM*** (Project 7) => 1 bentuk berlaku pada bentuk yg lain
    - OVERLOAD
        ```
        int Add(int x, int y)
        string Add(string x, string y)
        ```
    - OVERRIDE
        - Child (override) tidak perlu mengikuti parent (virtual)

**LATIHAN MANDIRI** <br>
Inheritance - Encap - Poly aku gabung jd satu => Stranger Things

---
> ### Day 4 - 03/08/2023 (Project 8-12)
*__4 PILAR OOP__*
- ***ABSTRACTION***
    - Class
        - Solid
        - Bisa dibuat instance
    - Abstract class
        - Solid + abstract
        - Tidak bisa dibuat instance
    - Interface
        - Full abstract
        - Tidak bisa dibuat instance
        - Bisa multiple inherit
        - Multiple interface di 1 class
        - Declare variabel dengan property/variable method
        - Anak interface => implement

**LATIHAN MANDIRI** <br>
- Interface CHECK
- Abstract CHECK
- Abstract interface (ada non abstract)
- Parent => child, begitu juga sebaliknya
---
> ### Day 5 - 04/08/2023 (Project 13-16)
***CASTING ADA 2 TIPE***
- Explicit (tipe data besar ke kecil) downcast
- Implicit (tipe data kecil ke besar) upcast

***PROSES BOXING***
- Membungkus data apapun menggunakan objek
- Class static tidak bisa dibuat instance

***PRINSIP DASAR PROGRAMMING***
- SOLID [Link penjelasan](https://kodebagus.medium.com/solid-principles-daf3282a4e70)
    - `Single Responsibility`
    - `Open Closed`
    - `Liskov Substitution`
    - `Interface Segregation`
    - `Dependency Inversion/Injention`
- DRY `Don't Repeat Yourself`
    - Semua bagian data hanya diproses di satu tempat
- KISS `Keep It Simple, Stupid`
    - Kode efisien dan sederhana


## WEEK 2
> ### Day 6 - 07/08/2023 (Project 18-)
- Review Upcast Downcast (Explicit Implicit)
- Pattern Matching (Project 18)
- Ref, In, Out (pass address as an argument)
    - Ref (Project 19)
        - Declare harus ada value nya
        - Yang dipassing address memory nya (pointer), bukan value
    - Out (Project 20)
        - Declare bisa kosongan
        - Passing kosongan, output harus ada value
        - Mengubah string ke int dengan `Parse`


```
string input = Console.ReadLine();
int x = int.Parse(input);
```


    - In (Project 21)
        - Tidak boleh diubah valuenya
        - Status read-only
- Value and Reference Type
    - String
        - Immutable
        - Pakai StringBuilder => append method (memori yg sama, tidak membuat memori baru) (Project 22)
- Const & read-only (Project 23)
    - Const
        - Static
        - Must assign value on variabel
    - Read-only
        - Dibuat instance
        - Empty variable, assign it via constructor
- Enum
- Generic
    - Bisa isi tipe data apapun tergantung user
---
> ### Day 7 - 08/08/2023
- Tipe2 class
    - Class concrete
    - Struct
    - Enum => data2 yg constant/collection of constant
    - Generic
    - Delegate
    - Abstract
    - Interface
- Delegate (pass method as an argument)<br>
``` public delegate void MyDel() ``` <br>
**Karakteristik *signature*** => method di dalamnya MUST HAVE THE SAME RETURN VALUE AND PARAMETER
    - Callback function
    - Publisher Subscriber (untuk notif)

- Tuple
---
> ### Day 8 - 09/08/2023
- Event: 
    - EventArgs.
    - tidak bisa = saja, bertambah sedikit2
- ExceptionHandler => try catch
- Parse, TryParse
---
> ### Day 9 - 10/08/2023
- Operator Overloading
- Enum => collection of constant data
- Try-Catch-Finally
- Enumerable (kendaraan) => return IEnumerator (mesin)
    - Object yg bisa di-iterasi
    - Bisa diterapkan di array/collection (list, dictionary)
    - Method `GetEnumerator` => bool MoveNext(), Reset()
    - Property `GetEnumerator` => Current
    - Bisa melakukan foreach
---
> ### Day 10 - 11/08/2023
- Substring => ngambil dari indeks awal ke indeks terakhir yg direquest
- ToUpper
- ToLower
- Trim => ngilangin seluruh spasi sebelum dan sesudah
- Replace => 
- Split
- Contains
- Convert
- DeadTime
- Equals Comparison => menggunakan address yg berisi value 
- FormatterParse

Value Type
    - int
    - double
    - decimal
    - long
    - char
    - double

Ref Type
    - Str
    - List
    - Class
    - Array
    - Object

---
## Week 3
> ### Day 11 - 14/08/2023
- Collection of multiple data YANG BISA DIUBAH, tidak seperti enum
    - Array
        - Fix size
        - Type safety
        - Index[]
    - ArrayList => multiple type of data
        - Dynamic size
        - NOT type safety (tipe data apapun bisa dicampur)
        - Index[]
    - List Generic<T>
        - Dynamic size
        - Type safety
        - Index[]
    - HashSet
        - Dynamic
        - Type safety
        - Unique, tidak ada data yg sama
    - LinkedList
        - Dynamic size
        - Type safety
        - Performance add/remove item in index
        - Data sangat bergantung pada index, maka menggunakan ini
        - Kekurangan: boros memori
- Dictionary
    - Safety
    - Dynamic
- Hashtable
    - Not safety
- SortedDictionary
    - Sort based on the key
    
> ### Day 12 - 15/08/2023
- Stack => kumpulan memori LIFO, ada versi generic
    - Push()
    - Pop()
    - Peek()
    - Clone() => pada value type yg digandakan instance nya, ref type address nya
    - CopyTo() => tidak saling ketergantungan
- Queue => ada versi generic
    - Enqueue()
    - Dequeue()
    - Peek()
- Class yg sama, namun beda file => use partial class (berguna untuk game)

> ### Day 13 - 16/08/2023
- Focus test one on one

> ### Day 14 - Day 15 (17/08/2023 - 18/08/2023)
- Libur 17an
---
## Week 4
> ### Day 16 - 21/08/2023
- WFH

> ### Day 17 - Day 20 (22/08/2023 - 25/08/2023)
- Project 1 (Class Diagram)
---
## Week 5
> ### Day 21 (28/08/2023)
- Perbedaan C/C++ dengan c#
    - 
- Coba aplikasi .NET Memory Profiler 
- Garbage Collection (move heap memory: gen0, gen1, gen2 => mark and sweep): using heap pointer
    - Work automatically based on time & memory size (random)
    - Dipanggil scr manual (FORCE GC) `GC.Collect();` , `GC.WaitForPendingFinalizers();` ga boleh dipanggil
    - *Side effect:* saat melakukan pembersihan, program akan stop for nanosecond
- Finalizer/Destructor
    - Dipanggil tepat sebelum GC melakukan pembersihan
    - Membuat program lebih lemot doang, ga boleh digunakan
    - Tidak bisa diisi access modifier, parameter, cukup kosongan
    ```
    public class Car{
        //destructor
        ~Car {
        
        }
    }
    ```
- Data Type
    - Managed Type (int, string, class, object) => garbage collection bisa membersihkan
    - Unmanaged Type (external resource: file, database, API, HTTP Request, networking) => Dispose Pattern
- `IDisposable` / Method `.Dispose();`
    - For cleaning the unmanaged type (external resources)
    - External resource tidak akan membebankan lagi
    - Efektif menggunakan `using` statement

> ### Day 22 (29/08/2023)
- Conditional Compilation / Preprocessing Directive
    - Meng-compile kode dari high level language (bahasa manusia) ke dalam low level language (bahasa assembly => .exe dan .dll) dengan menggunakan conditional (if else, elif)
    - Dijalankan sebelum compile, beda dengan if else biasa
    - Sintaks `#define` di file .cs
    - Sintaks `<DefineConstant>` di file .csproj
    - Terminal `dotnet build -c .... (nama file)`
- Debugger 
    - Mencari dan resolve bug
    - Pake breakpoint
    - Error ada 2: sintaks error (can't compile) dan logic error (still can compile)
    - Feature: HotReload (use dotnet watch run) => berguna untuk website 
- `"console": "integratedTerminal"` in .json file for input

### Day 23 (30/08/2023)
- Logging/Log (Record activity program)
    - Level <br>
        1-4 using third party library => log4nt, nLog, SeriLog
        5-6 internal library
        1. Fatal
        2. Error
        3. Warning
        4. Info
        5. Debug
        6. Trace
    - VSCode => Debug
    - Debugger => Terminal Debug/Console Debug
    - The assert() method tests if a given expression is true or not => debugging feature
    - `dotnet build` for Debug & Trace
    - `dotnet build -c Release` for Trace
- Trace
    - Collecting and recording the messages that are sent.
    - `TextWriterTraceListener` di file
    - `ConsoleTraceListener` di terminal biasa
    - Seperti publisher (Trace) subscriber (traceListener) di delegate
- DocumentationXML => optional

### Day 24 (31/08/2023)
- Multithreading (NOT RECOMMENDED low level)
    - Foreground Thread: Main Thread stop, another thread still running
    - Membuat banyak proses yang berjalan secara bersamaan
    - Concurrency: execute multiple task in same time
    - Asynchrony: akan dibahas saat async await
    - `Thread.Abort();` NOT RECOMMENDED caused Undefined State, like Destructor/Finalizer
    - Thread punya banyak Stack
    - Single threading => namanya Main Thread
    ```
    static void Main(){

    }
    ```
    - Property `Priority` or `Highest` tidak boleh dipakai
    - Passing parameter in Thread must using object
    - Passing parameter can using another data type, but using Lambda Expression ( ()=>.... ) on Main
- Task (RECOMMENDED high level)
    - Background Thread: Main Thread stop, another thread also stop
    - ThreadPool (kumpulan)
---
Method Join on Thread membuat Main Thread blocking & less performance
-- <br>

- Async-await
    - await hanya berlaku di return type Task
    - Task menampung status dan return value

### Day 25 (01/09/2023)
- Cancellation Token => stop the task
    - There are two:
        - `CancellationTokenSource` as Listener
        - `CancellationToken` as Status/Variable
- Multi Threading: RaceCondition
    - 2 or more threads to 1 variable (rebutan)
    - Solving with Lock Mechanism => kayak try catch
    ```
    static object counterLock = new object();
    lock (counterLock)
    ```
- Multi Threading: DeadLock
    - 2 or more threads tunggu2an
    - Solving with Async-Await & Technique
- Multi Threading: Semaphore

---
## Week 6
### Day 26 (04/09/2023)
- File 
    - Load File
    - Data kecil
- FileStream
    - Load File by chunk/buffer (streaming)
    - For big data
    - `StreamWriter` and `StreamReader`
    - Filepath
        - Absolute: full path
        - Relative: from working directory
    ```
    new FileStream(path, FileMode, FileAccess, FileShared)
    ```
    - class enum FileMode
        - CreateNew: if exist => exception
        - Create: if exist => replace
        - Open: if not found => exception
        - OpenOrCreate: open file, if not found => create
        - Truncate: When the file is opened, it should be truncated so that its size is zero bytes. 
        - Append: += file
    - class enum FileAccess
        - Read
        - Write
        - ReadWrite
    - FileShare (akses, opsional)
        - None
        - Read
        - ReadWrite
        - Inheritable
        - Delete

### Day 27 (05/09/2023)
- Serialization
    - Convert instance object to: 
        a. binary => obsolete
            use 3rd party package: protobuf-net, nuget package
        b. json {[]}
        c. XML <>
- Deserialize
