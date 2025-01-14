
# :game_die: Unity-GenWorldPro

![genworldlogo](https://user-images.githubusercontent.com/33583122/120931427-26cc9f00-c6fa-11eb-9b93-ae1c1fb5ec13.png)

**Unity-GenWorldPro** - a comprehensive procedural generation toolkit for the 'Unity' game engine. Facilitates procedural generation of scene content from voxels employing multiple algorithms. Customize the frequency of appearance, size, and color of voxel models.

## :notebook_with_decorative_cover: More About

*The project implements scene generation from voxels using three different algorithms.*

**Pseudo-Random Generation ”algorithm**. It is a simple generation algorithm based on adding voxels to the scene based on their color matching. This is a simple and classic method that first adds one random voxel and then selects another random voxel from all possible ones and checks if it can be added to already added voxels and so on until the whole scene is filled with random voxels.

**Weight-Direction Generation Algorithm**. This is a modified version of the previous algorithm, which was developed by improving the usual classical algorithm. second, it can rotate voxels in different directions, which increases the likelihood of adding them to the scene, but reduces speed. 

**Wave-Function Collapse algorithm**. Generation using WFC becomes intuitive, using this algorithm we show the program an example and get endless variants of it. There is also an aspect of collaboration with the machine, as the result obtained can be surprising and sometimes lead to a change in design. The algorithm calculates all possible options that are initially in the super position and selects the best one

## 🔌 Requirements

  * Git
  * Unity (version 2020.3.3f1)

## :white_square_button: Standard set of voxels

Together with the project, a set of 16 standard voxels has already been added inside, which can later be replaced with your own. But now you can run all the methods and algorithms along with a standard set of voxels for debugging, testing, or to study how the tool works. Below is an image showing all 16 models and their names. All voxel models were created using "MagicaVoxel". https://ephtracy.github.io/

![Voxels](https://user-images.githubusercontent.com/33583122/119365740-e9f3b780-bcb8-11eb-9a27-08fc812a51fc.png)

## :speech_balloon: How to interact

The project uses various buttons for user interaction with scene generation.

  * First press the button to select the algorithm;
  * You can press "Classic Pseudo-Random Voxel Generation";
  * You can press "Weight-Direction Voxel Generation";
  * You can press "Wave Function Collapse Voxel Generation";
  * You can press "Clear" button to clear the scene from voxels;
  * You can press "Close game application" to quit from game;

## 📷 GUI Screenshot

![GenWorld_1_1](https://user-images.githubusercontent.com/33583122/120931673-5203be00-c6fb-11eb-82c7-22c1c6157e4d.png)

## :bookmark_tabs: License

**[MIT](LICENSE)**

Copyright (c) 2021 hubotty

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.