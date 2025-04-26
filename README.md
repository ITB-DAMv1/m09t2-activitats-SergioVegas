# Exercici 1

La llibreria System.Diagnostics de .NET proporciona classes per interactuar amb processos del sistema, registres d'esdeveniments i comptadors de rendiment. 
## Classes destacades
- Process: Permet iniciar, aturar i gestionar processos del sistema.
- Debug: Ofereix mètodes per imprimir informació de depuració i comprovar la lògica del codi.
- Activity: Representa una operació amb context per a la traçabilitat.
- BooleanSwitch: Controla la sortida de depuració i traçabilitat amb un interruptor activat/desactivat.
## Mètodes útils
- Process.Start(): Inicia un nou procés.
- Process.Kill(): Atura un procés en execució.
- Debug.WriteLine(): Escriu un missatge de depuració a la consola.
- Activity.Start(): Inicia una activitat per a la traçabilitat.
## Propietats rellevants
- Process.Id: Retorna l'identificador del procés.
- Process.HasExited: Indica si el procés ha finalitzat.
- Debug.AutoFlush: Determina si la sortida de depuració s'ha de buidar automàticament.
- Activity.Tags: Permet afegir etiquetes descriptives a una activitat.
  
En aquest link es pot trobar més informació sobre la llibreria esmentada: https://learn.microsoft.com/es-es/dotnet/api/system.diagnostics?view=net-9.0.
