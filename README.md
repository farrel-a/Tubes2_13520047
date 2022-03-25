# Tugas Besar 2 IF2211 Strategi Algoritma Pemanfaatan Algoritma BFS dan DFS dalam Implementasi Folder Crawling

## Kelompok 45, My Tubes My Adventure
|NIM|Nama|
|---|---|
|13520047|Hana Fathiyah|
|13520053|Yohana Golkaria Nainggolan|
|13520110|Farrel Ahmad|

## DirTree File Finder
"_your truly systematic file finder_"

<img src="https://i.ibb.co/JcDQkRK/Dir-Tree-File-Finder-6.png" width = "200">

## Deskripsi Program
Sebuah aplikasi _GUI_ sederhana yang dapat memodelkan fitur dari _file explorer_ pada sistem operasi dengan memanfaatkan algoritma _Breadth First Search (BFS)_ dan _Depth First Search (DFS)_. Program ini dapat menelusuri folder-folder yang terdapat pada direktori untuk mendapatkan direktori yang diinginkan. Visualisasi pencarian berbentuk _path_ dan juga memanfaatkan kakas MSAGL.

## Requirements
Program ini membutuhkan library MSAGL (Microsoft Automatic Graph Layout) yang harus diunduh menggunakan console pada NuGet Pacakge Manager.
Langkah instalasi:
```
Install-Package AutomaticGraphLayout -Version 1.1.11
Install-Package AutomaticGraphLayout.Drawing -Version 1.1.11
Install-Package AutomaticGraphLayout.WpfGraphControl -Version 1.1.11
Install-Package AutomaticGraphLayout.GraphViewerGDI -Version 1.1.11
```

## Cara Compile
Berikut adalah langkah-langkah untuk menjalankan program
1. Clone repository ini.
```
git clone https://github.com/farrel-a/Tubes2_13520047.git
```

2. Buka Visual Studio dan click "Open a project or solution".
3. Buka directory dari hasil clone repository dan buka file bernama `DirTree File Finder.sln` yang ada berada di `Tubes2_13520047\src\DirTree File Finder\DirTree File Finder.sln`.
4. Click start pada Visual Studio untuk compile sekaligus menjalankan program.
5. Masukkan start directory, nama file, metode pencarian (BFS/DFS), dan pencarian satu file atau keseluruhan.

## Cara Menjalankan Program
1. Buka directory hasil clone repository
2. Buka directory bin dan jalankan program `.exe` nya
3. Masukkan start directory, nama file, metode pencarian (BFS/DFS), dan pencarian satu file atau keseluruhan.

## Contoh Hasil

![](https://i.ibb.co/TrQj7KJ/BFS.png)
Menggunakan BFS
![](https://i.ibb.co/L9cvDKX/DFS.png)
Menggunakan DFS
