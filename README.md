Perfecto 👌
Aquí tienes una **guía básica y clara para empezar a trabajar con C#**, tanto en **VS Code** como en **Visual Studio**, y además cómo se relaciona con **Visual Basic (VB.NET)** para que no te confundas.

---

# 🧭 GUÍA BÁSICA DE C#

*(VS Code · Visual Studio · relación con Visual Basic)*

---

## 1️⃣ Herramientas: ¿qué usar?

### 🟦 Visual Studio (RECOMENDADO para principiantes)

✔ Ideal para **Windows Forms, WPF, ASP.NET**
✔ Todo integrado
✔ Soporta **C# y Visual Basic**

👉 Descarga: [https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/)

Selecciona cargas de trabajo:

* ✔ Desarrollo de escritorio con .NET
* ✔ ASP.NET y web (si lo necesitas)

---

### 🟩 VS Code (ligero)

✔ Ideal para **consola, API, .NET Core**
✔ Más rápido
❌ No ideal para WinForms VB

Necesitas instalar:

* .NET SDK
* Extensiones

---

## 2️⃣ Instalar .NET SDK

Verifica:

```bash
dotnet --version
```

Descarga si no lo tienes:
👉 [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

---

## 3️⃣ C# en **Visual Studio**

### 📁 Crear proyecto

1. **Nuevo proyecto**
2. **Aplicación de consola / WinForms / Web API**
3. Lenguaje: **C#**

---

### 📂 Estructura básica C#

```text
MiApp/
├── Program.cs
├── MiApp.csproj
└── bin/
```

### 🧩 Program.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola C#");
    }
}
```

▶ Ejecutar: **F5**

---

## 4️⃣ C# en **VS Code**

###  Extensiones necesarias

* **C# Dev Kit**
* **C#**
* **.NET Install Tool**

---

###  Crear proyecto

```bash
dotnet new console -n MiApp
cd MiApp
code .
```

---

### ▶ Ejecutar

```bash
dotnet run
```

---

## 5️⃣ Conceptos básicos de C#

### Variables

```csharp
int edad = 20;
string nombre = "Ana";
```

### Condiciones

```csharp
if (edad >= 18)
{
    Console.WriteLine("Mayor de edad");
}
```

### Métodos

```csharp
static int Sumar(int a, int b)
{
    return a + b;
}
```

### Clases

```csharp
class Persona
{
    public string Nombre { get; set; }
}
```

---

## 6️⃣ Visual Basic vs C# (equivalencias)

| C#         | Visual Basic  |
| ---------- | ------------- |
| using      | Imports       |
| class      | Class         |
| static     | Shared        |
| void       | Sub           |
| Main       | Main (oculto) |
| Program.cs | My Project    |

Ejemplo:

**C#**

```csharp
Console.WriteLine("Hola");
```

**VB**

```vb
Console.WriteLine("Hola")
```

---

## 7️⃣ WinForms: diferencia clave

| C#                 | Visual Basic         |
| ------------------ | -------------------- |
| Program.cs visible | Main oculto          |
| Application.Run    | Formulario de inicio |

 En VB:

```
Proyecto → Propiedades → Aplicación
```

---

## 8️⃣ Buenas prácticas

✔ Un archivo = una clase
✔ No mezclar lógica con interfaz
✔ Usar nombres claros
✔ No tocar archivos Designer
✔ Usar Git desde el inicio

---

## 9️⃣ Ruta recomendada para aprender

1️⃣ C# consola
2️⃣ Clases y métodos
3️⃣ Colecciones
4️⃣ WinForms o Web API
5️⃣ Bases de datos
6️⃣ Git + GitHub


