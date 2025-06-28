# 📊 Analizador de Ventas de Ropa

Una aplicación de escritorio desarrollada en C# con Windows Forms que permite analizar datos de ventas de ropa mediante la importación de archivos Excel, generación de gráficos interactivos y exportación de reportes con análisis de IA.



## 🚀 Características Principales

### 📈 Análisis de Datos
- **Importación de archivos Excel** (.xlsx) con datos de ventas
- **Filtrado avanzado** por fechas, productos y categorías
- **Estadísticas en tiempo real**: total de ganancias, producto estrella, promedio mensual
- **Simulación de ventas** paso a paso para análisis dinámico

### 📊 Visualización
- **Gráfico de productos**: distribución de ventas por producto (gráfico de columnas)
- **Gráfico de tendencias**: evolución de ventas mensuales (gráfico lineal)
- **Tabla de datos** filtrable y ordenable
- **Interfaz moderna** con MetroFramework

### 📄 Exportación y Reportes
- **Exportación a PDF** con análisis generado por IA
- **Exportación a Excel** (.xlsx) para análisis adicional
- **Exportación a CSV** para compatibilidad universal
- **Análisis automático** mediante integración con API de IA

### 🎨 Interfaz de Usuario
- **Tema claro y oscuro** intercambiable
- **Diseño responsivo** con paneles organizados
- **Tooltips informativos** en todos los controles
- **Sistema de logs** en tiempo real
- **Barra de progreso** para operaciones largas

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# (.NET Framework 4.7.2+)
- **UI Framework**: Windows Forms con MetroFramework
- **Gráficos**: System.Windows.Forms.DataVisualization.Charting
- **Lectura Excel**: ExcelDataReader
- **Exportación PDF**: iTextSharp
- **Concurrencia**: Task-based Asynchronous Pattern (TAP)
- **IA**: Integración con API externa para análisis

## 📋 Requisitos del Sistema

### Requisitos Mínimos
- **Sistema Operativo**: Windows 7 SP1 o superior
- **Framework**: .NET Framework 4.7.2 o superior
- **Memoria RAM**: 2 GB mínimo
- **Espacio en disco**: 100 MB disponibles

### Requisitos Recomendados
- **Sistema Operativo**: Windows 10/11
- **Framework**: .NET Framework 4.8
- **Memoria RAM**: 4 GB o más
- **Procesador**: Dual-core 2.0 GHz o superior

## 🚀 Instalación

### Opción 1: Descarga Directa
1. Ve a la sección [Releases](../../releases)
2. Descarga la última versión `AnalizadorVentasRopa.exe`
3. Ejecuta el archivo y sigue las instrucciones

### Opción 2: Compilación desde Código Fuente
```bash
# Clonar el repositorio
git clone https://github.com/jona2333/trabajo-programacion-analizador-de-ventas.git

# Navegar al directorio
cd trabajo-programacion-analizador-de-ventas

# Restaurar paquetes NuGet
nuget restore

# Compilar el proyecto
msbuild AnalizadorVentasRopa.sln /p:Configuration=Release
```

## 📖 Guía de Uso

### 1. Preparación de Datos
Prepara un archivo Excel (.xlsx) con las siguientes columnas obligatorias:
- **Fecha**: Fecha de la venta (formato fecha)
- **Producto**: Nombre del producto vendido
- **Cantidad**: Cantidad vendida (número entero)
- **Precio**: Precio unitario (número decimal)
- **Categoria**: Categoría del producto

**Ejemplo de estructura:**
```
Fecha       | Producto    | Cantidad | Precio | Categoria
2024-01-15  | Camisa      | 5        | 25.99  | Ropa
2024-01-16  | Pantalón    | 3        | 45.50  | Ropa
2024-01-17  | Zapatos     | 2        | 89.99  | Calzado
```

### 2. Cargar Datos
1. Haz clic en **"📂 Cargar archivo"**
2. Selecciona tu archivo Excel
3. Espera a que se complete la carga y análisis inicial

### 3. Aplicar Filtros
- **Rango de fechas**: Selecciona fechas de inicio y fin
- **Producto**: Filtra por producto específico
- **Categoría**: Filtra por categoría específica
- Haz clic en **"🔍 Filtrar"** para aplicar

### 4. Visualizar Resultados
- **Panel de estadísticas**: Observa las métricas clave
- **Gráficos**: Analiza las tendencias visuales
- **Tabla de datos**: Revisa los datos filtrados

### 5. Simular Ventas
- Haz clic en **"▶️ Simular ventas"** para ver el análisis paso a paso
- Observa cómo cambian las métricas con cada venta procesada

### 6. Exportar Reportes
1. Haz clic en **"📊 Exportar datos"**
2. Selecciona el formato deseado (PDF, Excel, CSV)
3. Elige la ubicación de guardado
4. El reporte se generará automáticamente

## 🏗️ Arquitectura del Proyecto

```
AnalizadorVentasRopa/
├── Models/
│   └── Venta.cs                 # Modelo de datos de venta
├── Services/
│   ├── AnalisisService.cs       # Lógica de análisis de datos
│   ├── ExcelService.cs          # Importación de archivos Excel
│   ├── GraficoService.cs        # Generación de gráficos
│   └── ReporteService.cs        # Exportación de reportes
├── Utils/
│   └── ConcurrencyUtils.cs      # Utilidades de concurrencia
├── Forms/
│   ├── Form1.cs                 # Formulario principal
│   └── Form1.Designer.cs        # Diseño del formulario
└── Program.cs                   # Punto de entrada
```

### Servicios Principales

#### AnalisisService
```csharp
// Ejemplo de uso del servicio de análisis
var analisisService = new AnalisisService();
analisisService.Analizar(ventas, fechaInicio, fechaFin, producto, categoria);

// Obtener resultados
decimal totalGanancias = analisisService.TotalGanancias;
string mejorProducto = analisisService.MejorProducto;
var topProductos = analisisService.TopProductos();
```

#### ExcelService
```csharp
// Cargar datos desde Excel
var excelService = new ExcelService();
var ventas = excelService.LeerVentasDesdeExcel("ruta/archivo.xlsx");
```

#### GraficoService
```csharp
// Generar gráficos
var graficoService = new GraficoService();
graficoService.GenerarGraficoProductos(topProductos, chartControl);
graficoService.GenerarGraficoMeses(ventasPorMes, chartControl);
```

## ⚡ Características Técnicas

### Programación Asíncrona
- Uso de `async/await` para operaciones de I/O
- Interfaz no bloqueante durante procesamientos largos
- Manejo de concurrencia con `SemaphoreSlim`

### Manejo de Errores
- Try-catch comprehensivo en todas las operaciones
- Logging detallado de errores y eventos
- Mensajes de error informativos para el usuario

### Optimización de Rendimiento
- Procesamiento en hilos separados para operaciones pesadas
- Actualización eficiente de controles UI
- Gestión de memoria optimizada

## 🔧 Configuración Avanzada

### API de IA para Análisis
Para habilitar el análisis con IA en los reportes PDF, configura tu API key:

```csharp
// En ReporteService.cs o archivo de configuración
string apiKey = "tu-api-key-aqui";
```

### Personalización de Gráficos
Modifica los colores y estilos en `GraficoService.cs`:

```csharp
private Color GetColorForIndex(int index)
{
    Color[] colors = {
        Color.FromArgb(124, 65, 153),   // Púrpura personalizado
        Color.FromArgb(0, 174, 219),    // Azul personalizado
        // Agrega más colores...
    };
    return colors[index % colors.Length];
}
```

## 🐛 Solución de Problemas

### Problemas Comunes

**Error al cargar archivo Excel**
- Verifica que el archivo tenga las columnas requeridas
- Asegúrate de que el archivo no esté abierto en otra aplicación
- Confirma que el formato sea .xlsx

**Gráficos no se actualizan**
- Verifica que hay datos después del filtrado
- Reinicia la aplicación si el problema persiste
- Revisa los logs para errores específicos

**Exportación falla**
- Confirma permisos de escritura en la carpeta destino
- Verifica que no hay archivos con el mismo nombre abiertos
- Revisa la configuración de API si usas exportación PDF con IA

### Logging y Depuración
La aplicación mantiene un log detallado en el panel inferior. Los eventos incluyen:
- ✅ Operaciones exitosas
- ⚠️ Advertencias y validaciones
- ❌ Errores y excepciones
- 📊 Información de procesamiento

## 🤝 Contribución

¡Las contribuciones son bienvenidas! Para contribuir:

1. **Fork** el repositorio
2. Crea una **rama feature** (`git checkout -b feature/nueva-caracteristica`)
3. **Commit** tus cambios (`git commit -am 'Agrega nueva característica'`)
4. **Push** a la rama (`git push origin feature/nueva-caracteristica`)
5. Crea un **Pull Request**

### Estándares de Código
- Usa nombres descriptivos para variables y métodos
- Comenta código complejo
- Sigue las convenciones de C#
- Incluye manejo de errores apropiado



## 👨‍💻 Autor

**Jonathan** ([@jona2333](https://github.com/jona2333))


---

⭐ **¡Si este proyecto te ha sido útil, no olvides darle una estrella!** ⭐
