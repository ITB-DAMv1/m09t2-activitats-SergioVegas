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

# Exercici 4
La classe Thread en .NET permet la creació i gestió de fils per a l'execució concurrent de tasques. Per altra banda, Task és una abstracció més moderna que facilita la programació asíncrona i la gestió de fils de manera més eficient.
## Mètodes destacats de Thread
- Start() – Inicia l'execució del fil.
- Join() – Espera que el fil acabi abans de continuar.
- Sleep(ms) – Pausa el fil durant un temps determinat.
- Abort() (obsolet) – Intenta aturar el fil de manera abrupta.
- IsAlive (propietat) – Indica si el fil encara s'està executant.


## Característiques de Thread:
- Creació: Es instancia manualment amb new Thread().

- Execució asíncrona: S'inicia amb Start(), però no està integrat amb async/await.

- Finalització: Es pot esperar el final amb Join().

- Interrupció: Es pot utilitzar Interrupt() o Abort() (deprecated).

- Gestió d'excepcions: Necessita capturar excepcions manualment.

- Retorn de valors: No pot retornar valors directament.

- Prioritat: Es pot configurar amb Thread.Priority.

- Compartició de dades: Necessita sincronització manual amb lock, Monitor, etc.

- Optimització de CPU: No utilitza ThreadPool automàticament.

- Adequat per a: Operacions de llarga durada o gestió manual de fils.
## Característiques de Task:
- Creació: Es fa amb Task.Run() o new Task().

- Execució asíncrona: Està optimitzat per a async/await.

- Finalització: S'espera amb await task.

- Interrupció: Utilitza CancellationToken per a una cancel·lació controlada.

- Gestió d'excepcions: Es gestiona fàcilment amb try/catch dins de async/await.

- Retorn de valors: Pot retornar valors amb Task<TResult>.

- Prioritat: No té prioritat explícita.

- Compartició de dades: Gestiona concurrència amb col·leccions segures (ConcurrentDictionary, etc.).

- Optimització de CPU: Utilitza ThreadPool automàticament.

- Adequat per a: Operacions curtes, escalables i gestió automàtica de fils.



En general, Task és preferible per a la programació asíncrona, ja que simplifica la gestió de fils i millora el rendiment. Thread encara és útil en casos on es necessita un control més directe sobre l'execució.
