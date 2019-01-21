ParticleEffectForUGUI
===

This plugin provide a component to render particle effect for uGUI in Unity 2018.2+.  
The particle rendering is maskable and sortable, without Camera, RenderTexture or Canvas.

[![](https://img.shields.io/github/release/mob-sakai/ParticleEffectForUGUI.svg?label=latest%20version)](https://github.com/mob-sakai/ParticleEffectForUGUI/releases)
[![](https://img.shields.io/github/release-date/mob-sakai/ParticleEffectForUGUI.svg)](https://github.com/mob-sakai/ParticleEffectForUGUI/releases)  
![](https://img.shields.io/badge/requirement-Unity%202018.2%2B-green.svg)
[![](https://img.shields.io/github/license/mob-sakai/ParticleEffectForUGUI.svg)](https://github.com/mob-sakai/ParticleEffectForUGUI/blob/master/LICENSE.txt)  
[![](https://img.shields.io/github/last-commit/mob-sakai/ParticleEffectForUGUI/develop.svg?label=last%20commit%20to%20develop)](https://github.com/mob-sakai/ParticleEffectForUGUI/commits/develop)
[![](https://img.shields.io/github/issues/mob-sakai/ParticleEffectForUGUI.svg)](https://github.com/mob-sakai/ParticleEffectForUGUI/issues)



<< [Description](#Description) | [WebGL Demo](#demo) | [Download](https://github.com/mob-sakai/ParticleEffectForUGUI/releases) | [Usage](#usage) | [Development Note](#development-note) | [Change log](https://github.com/mob-sakai/ParticleEffectForUGUI/blob/master/CHANGELOG.md) >>

### What's new? Please see [RELEASE NOTE ![](https://img.shields.io/github/release-date/mob-sakai/ParticleEffectForUGUI.svg?label=last%20updated&style=for-the-badge)](https://github.com/mob-sakai/ParticleEffectForUGUI/blob/master/CHANGELOG.md)




<br><br><br><br>
## Description

![](https://user-images.githubusercontent.com/12690315/41771577-8da4b968-7650-11e8-9524-cd162c422d9d.gif)

This plugin uses new APIs `MeshBake/MashTrailBake` (added with Unity 2018.2) to render particles by CanvasRenderer.
You can mask and sort particles for uGUI without Camera, RenderTexture, Canvas.

Compares this "Baking mesh" approach with the conventional approach:  
(This scene is included in the package.)

|Approach|Good|Bad|Screenshot|
|-|-|-|-|
|Baking mesh<br>**\(UIParticle\)**|Rendered as is.<br>Maskable.<br>Sortable.<br>Less objects.|**Requires Unity 2018.2+.**<br>Requires UI shaders to use Mask.|<img src="https://user-images.githubusercontent.com/12690315/41765089-0302b9a2-763e-11e8-88b3-b6ffa306bbb0.gif" width="500px">|
|Do nothing|Rendered as is.|**Looks like a glitch.**<br>Not maskable.<br>Not sortable.|<img src="https://user-images.githubusercontent.com/12690315/41765090-0329828a-763e-11e8-8d8a-f1d269ea3bc7.gif" width="500px">|
|Convert particle to UIVertex<br>[\(UIParticleSystem\)](https://forum.unity.com/threads/free-script-particle-systems-in-ui-screen-space-overlay.406862/)|Maskable.<br>Sortable.<br>Less objects.|**Adjustment is difficult.**<br>Requires UI shaders.<br>Difficult to adjust scale.<br>Force hierarchy scalling.<br>Simulation results are incorrect.<br>Trail, rotation of transform, time scaling are not supported.|<img src="https://user-images.githubusercontent.com/12690315/41765088-02deb9c6-763e-11e8-98d0-9e0c1766ef39.gif" width="500px">|
|Use Canvas to sort|Rendered as is.<br>Sortable.|**You must to manage sorting orders.**<br>Not maskable.<br>More batches.|<img src="https://user-images.githubusercontent.com/12690315/41765087-02b866ea-763e-11e8-8c33-081c9ad852f8.gif" width="500px">|
|Use RenderTexture|Maskable.<br>Sortable.|**Requires Camera and RenderTexture.**<br>Difficult to adjust position and size.<br>Quality depends on the RenderTexture's setting.|<img src="https://user-images.githubusercontent.com/12690315/41765085-0291b3e2-763e-11e8-827b-72e5ee9bc556.gif" width="500px">|




<br><br><br><br>
## Demo

[WebGL Demo](http://mob-sakai.github.io/ParticleEffectForUGUI)



<br><br><br><br>
## Usage

1. Download ParticleEffectForUGUI.unitypackage from [Releases](https://github.com/mob-sakai/ParticleEffectForUGUI/releases).
1. Import the package into your Unity project. Select `Import Package > Custom Package` from the `Assets` menu.
1. Add particle system to canvas.
1. (Option) If you want to mask particles, set a UI shader such as "UI/UIAdditive" to material for ParticleSystem.  
![](https://user-images.githubusercontent.com/12690315/42674022-134e3a40-86a9-11e8-8f44-a110d2f14185.gif)
1. Add `UIParticle` component to particle system from `Add Component` in inspector.  
![](https://user-images.githubusercontent.com/12690315/41772125-5aca69c8-7652-11e8-8442-21f6015069a1.png)
1. That's all. There are no properties you must set in the inspector!
1. Enjoy!


##### Requirement

* Unity 2018.2+ (Tested in Unity 2018.2.0f2)
* No other SDK are required




<br><br><br><br>
## Development Note




<br><br><br><br>
## License

* MIT
* © UTJ/UCL



## Author

[mob-sakai](https://github.com/mob-sakai)



## See Also

* GitHub page : https://github.com/mob-sakai/ParticleEffectForUGUI
* Releases : https://github.com/mob-sakai/ParticleEffectForUGUI/releases
* Issue tracker : https://github.com/mob-sakai/ParticleEffectForUGUI/issues
* Current project : https://github.com/mob-sakai/ParticleEffectForUGUI/projects/1
* Change log : https://github.com/mob-sakai/ParticleEffectForUGUI/blob/master/CHANGELOG.md
