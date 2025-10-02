# 📚 Colecciones C# – Seminario II

Aplicación educativa en **C# (.NET 8.0)** que enseña **Listas**, **Pilas**, **Colas** y **Diccionarios** con ejemplos interactivos y ejercicios guiados.

---

## 🎯 Objetivo
Facilitar el aprendizaje práctico de las colecciones genéricas de C# aplicando **POO** y arquitectura **por capas**.

---

## 🧰 Tecnologías utilizadas

- 🖥️ Lenguaje: **C#**
- ⚙️ Framework: **.NET 8.0**
- 🧑‍💻 IDE: **Visual Studio 2022**
- 🏗️ Arquitectura: **Por capas** (Interfaz – Lógica de negocio)
- 📐 Paradigma: **Programación orientada a objetos (POO)**

---

## 🏗️ Arquitectura del proyecto

El proyecto utiliza una **arquitectura por capas** sencilla que separa responsabilidades y mejora la organización del código:

- 🧑‍🎨 **Capa de Presentación (UI):** Formularios Windows Forms que manejan la interacción con el usuario.  
  - Ej.: `Aplicacion_Central.cs` – Gestión de eventos, navegación e interfaz gráfica.

- 🧠 **Capa de Lógica de Negocio:** Contiene las reglas y operaciones principales de la aplicación.  
  - Ej.: `Metodos.cs` – Implementación de la lógica utilizada por la UI.

---

## 📁 Estructura
- **📁Ayuda/** -> docs extra
- **📁Media/** -> logo, sonidos
- **📁Ejemplos\_de\_Ejercicios/** ->  FormEjColas, FormEjDictionary, FormEjListas, FormEjPilas
- **📁Ejercicios/** -> FormColas, FormListas, FormPilas
- **📄Aplicacion\_Central.cs** -> UI principal
- **📄Metodos.cs** -> lógica de negocio
- **📄README.md** -> este archivo


---

## ⚙️ Ejecución
1. Clonar:  
   ```bash  
   git clone https://github.com/Taikaros/Colecciones-CSharp-Seminario-II.git  
- Abrir *.sln en VS 2022.*
- Abrir *.sln en VS 2022.*
- Ctrl + Shift + B → compilar.
- F5 → ejecutar.


---
## 📋 Ejemplo – Uso de List<T>

**Este ejemplo muestra cómo administrar una lista de nombres, permitiendo agregar, eliminar y ordenar elementos:**
   ~~~~csharp 
    List<string> listaNombres = new List<string>();

    // Agregar un nuevo nombre
    private void btn_agregar_Click(object sender, EventArgs e)
    {
        listaNombres.Add(txb_Ingresar.Text);
        dataGridView1.Rows.Add(txb_Ingresar.Text);
    }

    // Eliminar el nombre seleccionado
    private void btn_Eliminar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow == null) return;

        int rowIndex = dataGridView1.CurrentRow.Index;
        if (rowIndex >= 0 && rowIndex < listaNombres.Count)
        {
            listaNombres.RemoveAt(rowIndex);
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }

    // Ordenar alfabéticamente
    private void btn_Ordenar_Click(object sender, EventArgs e)
    {
        listaNombres.Sort();
        dataGridView1.Rows.Clear();
        foreach (var nombre in listaNombres)
        {
            dataGridView1.Rows.Add(nombre);
        }
    } 
    ~~~

📌 ``List<T>`` permite almacenar colecciones dinámicas, ordenarlas con ``.Sort()`` y acceder a sus elementos de forma sencilla.

---
## 📊 Casos de uso sugeridos

Este proyecto es ideal para:

- **🧑‍🎓 Estudiantes** que estén aprendiendo colecciones en C#.

- **🧑‍🏫 Docentes** que necesiten ejemplos claros para explicar estructuras de datos.

- **🧪 Prácticas académicas** sobre listas, colas, pilas y diccionarios.

- **🛠️ Prototipos educativos** donde se requiera manipulación básica de datos en memoria.
---
## 🧪 Pruebas recomendadas

Para comprobar el correcto funcionamiento del proyecto:
<ol>

1. **Agregar y eliminar elementos** en cada colección y verificar los cambios en el DataGridView.

2. **Probar operaciones inválidas** (por ejemplo, eliminar de una cola vacía) y comprobar el manejo de excepciones.

3. **Ordenar** listas con elementos repetidos y confirmar el orden alfabético.

4. **Ver el comportamiento** FIFO y LIFO en colas y pilas respectivamente.

5. **Usar claves** duplicadas en diccionarios para observar cómo se manejan los conflictos.
<ol>

---
## 📚 Recursos adicionales
- [Documentación oficial de C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Guia de Colecciones -Google Drice](https://docs.google.com/presentation/d/1ovQafJAdOlzaLYvgmhH8xWwXasgMfOoGkHQF8ztzte4/edit?usp=sharing)
---
## 🏢 Desarrollado por
- **Codigo Universitario** – Soluciones educativas y herramientas académicas en C#
- 📧 [Gabrielss365@gmail.com](mailto:Gabrielss365@gmail.com)
***
## 📝 Licencia
Este proyecto está bajo la Licencia MIT.