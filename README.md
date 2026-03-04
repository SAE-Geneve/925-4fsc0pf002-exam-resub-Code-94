# 925 4FSC0PF002 Resubmission

### Le jeu
Un jeu de gestion ferroviaire où le joueur clique sur les aiguillages et les signaux pour guider un train à travers des stations avant la fin du chronomètre.

### Splines dans Unity
Un **SplineContainer** définit un chemin composé de points de contrôle. Le composant **SplineAnimate** déplace un GameObject le long de ce chemin (valeur normalisée 0→1). En changeant le SplineContainer à la fin de l'animation et en la relançant, on peut enchaîner les tronçons de voie.


## Consignes
### Ajouter les fonctionnalités suivantes :
- 2pts : utiiser les prefabs **Red Lights** pour arreter le train sur la voie
  - Le train doit s'arreter au niveau du drapeau
  - Le train doit ralentir progressivement
  - indiquer dans la scene si le passage est autorisé ou non
- 1 pt : Ajouter un systene de chronometre pour arreter le jeu au bout d'un temps donné
- 1 pt : Pour les objets **Junction**, indiquer dans la scene la sortie d'aiguillage active
- 1 pt : Creer un système de score à chaque passage du train dans la station

### Ajouter un système d'interface HUD, pour :
  - 1 pt : Ajouter des boutons pour :
    - Mettre en pause
    - Démarrer
    - Doubler la vitesse du jeu
  - 0,5 pt : Afficher le chronometre
  - 0,5 pt : Afficher le score 
  - **PAS DE MENU**

## Evaluation
- Chaque consigne est évalué comme suit :
  - 50 % : Respect des consignes
  - 50 % : Qualité du code (fiabilité, coding style, extensivité)# UnityEmpty
