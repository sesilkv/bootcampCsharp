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
    - Publisher Subscriber

- Tuple
---
> ### Day 8 - 09/08/2023
- Event: 
    - EventArgs.
    - tidak bisa = saja
- ExceptionHandler => try catch
- Parse, TryParse
---
> ### Day 9 - 10/08/2023
- Operator Overloading
- Enum => collection of constant data
- Enumerator - Denominator
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

> ### Day 13 - 16/08/2023