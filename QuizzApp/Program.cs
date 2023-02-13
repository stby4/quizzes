// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// what?! #1
int[] arr = new int[64 * 1024 * 1024];

// Loop 1: 80ms
for (var i = 0; i < arr.Length; i++)
    arr[i] *= 3;

// Loop 2: 78ms
for (var i = 0; i < arr.Length; i += 16)
    arr[i] *= 3;

// what?! #2
int[] a = new int[2];

// Loop 1: 500 ms
for (var i = 0; i < 100_000_000; i++)
{
    a[0]++;
    a[0]++;
}

// Loop 2: 250 ms
for (var i = 0; i < 100_000_000; i++)
{
    a[0]++;
    a[1]++;
}

