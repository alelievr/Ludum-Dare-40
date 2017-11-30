# JamStartupKit
A Unity kit of assets and scripts for game jams

### Installation
clone this repo using `git clone --recursive https://github.com/alelievr/3D-JamStartupKit` to get the submodules.

:warning: there is multiple branches with different 3D setups in this repo:

branch | description
--- | ---
Terrain | Terrain tools and nature assets

### Assets included
+ [Post processing stack](https://www.assetstore.unity3d.com/en/#!/content/83912)
+ [DOTween](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)
+ [Cinemachine](https://www.assetstore.unity3d.com/en/#!/content/79898)
+ [ProBuilder Basic](https://www.assetstore.unity3d.com/en/#!/content/11919)
+ [Unity particle pack](https://www.assetstore.unity3d.com/en/#!/content/73777)
+ [JamKit](https://github.com/alelievr/JamKit)

### Modified project settings
Chnages done accordingly to [the project setup best practices](https://blogs.unity3d.com/2017/08/10/spotlight-team-best-practices-project-setup/)

+ Fixed timestep to 0.01666
+ Maximum Allowed Timestep to 0.1
+ Gamma color space (for web target else use linear)
+ Graphics jobs false (causes lag spike on old GPUs)
+ GPU Skinning to true
+ Anti aliasing to disabled
+ VSync to disabled
+ Asset serialization to force text
