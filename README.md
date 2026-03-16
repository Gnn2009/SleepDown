<div align="center">
  <pre>
    __  ___   _____  ____ 
   /  |/  /  / ___/ /  _/ 
  / /|_/ /   \__ \  / /   
 / /  / /   ___/ /_/ /    
/_/  /_/   /____//___/    
  </pre>
  <h1>S I S T E M A   M S I</h1>
  <p><strong>Proyecto:</strong> SleepDown</p>
  <p><strong>Lenguaje:</strong> C# (Console App) 🎯</p>
</div>

---

## 🚀 Descripción
**SleepDown** es una utilidad rápida de línea de comandos diseñada para programar el apagado automático de tu sistema. Perfecta para cuando dejas procesos largos ejecutándose, descargar archivos pesados o simplemente quieres escuchar música antes de dormir sin que tu computadora se quede encendida toda la noche.

## ✨ Funcionalidades
1. **Temporizador Personalizado:** Te pregunta directamente en cuántos minutos deseas que el equipo se apague.
2. **Validación de Entrada:** Asegura que ingreses un número de minutos válido y mayor a cero.
3. **Botón de Pánico (Cancelar):** Una vez programado el apagado, la aplicación queda a la escucha. Si cambias de opinión, simplemente escribe `cancelar` y el sistema abortará la cuenta regresiva inmediatamente.

## 🛠️ Tecnologías
- C# / .NET
- Interacción con procesos del sistema operativo (`System.Diagnostics.Process`) invocando comandos nativos de `shutdown`.

## ⚙️ Instalación y Ejecución
Asegúrate de tener instalado el SDK de .NET. Luego, desde la terminal en el directorio del proyecto:

```bash
# Para compilar y ejecutar el proyecto:
dotnet run
```

> *Si lo crees, lo creas. Automatización de Sistema MSI.*