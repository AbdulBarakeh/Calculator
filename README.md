![Size](https://img.shields.io/github/languages/code-size/SWT12F19/Calculator.svg?style=flat)
![LastCommit](https://img.shields.io/github/last-commit/SWT12F19/Calculator.svg?style=flat)
![Language](https://img.shields.io/github/languages/top/SWT12F19/Calculator.svg?style=flat)

# Calculator

In this exercise the purpose is to practice the use of Git by extending the Calculator with new functionality and tests. This is achieved by sharing the work and make changes parallel.

## Table of contents
1. [Requirements](#requirements)
2. [Contribution](#contribution)
    1. [Clone](#cloning)
    2. [Workflow](#workflow)
3. [Tasks](#tasks)
4. [Files](#files)

## Requirements <a name="requirements"></a>
- Git for Windows
- Tortoise / other
- Github Extension for Visual Studio

## Contribution <a name="contribution"></a>
When contributing to this repository, please check the needed tasks to be done before starting. It is important to check if a branch to a certain task is already made, before making a new. Also, read how to clone this repository and when contributing please follow the workflow description.

### Cloning <a name="cloning"></a>
Cloning with HTTP:

```git clone https://github.com/SWT12F19/Calculator.git```

### Workflow <a name="workflow"></a>

> When two developers start working on two separate functionalities within one project, problems begin to appear. This is where branches the core feature of Git comes in handy. Branches are independent “tracks” of developing a project. For each new functionality, a new branch should be created, where the new feature is developed and tested. Once the feature is ready, the branch can be merged to the master branch so it can be released

Every new feature results in a new branch. Naming convention should be ```feature/{NameOfFeature}```

After pushing changes remote repository and if feature is implemented and testes, then make a pull request

## Tasks <a name="tasks"></a>
This list contains all the sub-exercises of the exercise.

- [X] Install Git Tools
- [X] Team Up
- [X] Github Setup
- [X] Calculator Functionality
    - [X] Divide
    - [X] Accumulator
    - [X] Clear
    - [ ] Overloading
    - [ ] Power

## Files <a name="files"></a>
- [Calculator Class](UnitTestingCalculator/Calculator/Calculator.cs)
- [Calculator Unit Test](UnitTestingCalculator/Calculator.Test.Unit/CalculatorUnitTests.cs)

