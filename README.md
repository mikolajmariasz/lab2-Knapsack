# lab2_Knapsack

This project is a laboratory assignment implementing a solution to the Knapsack Problem in C#. It includes a console application, a Windows Forms GUI, and unit tests.

## Knapsack Problem Description

The Knapsack Problem is a classic optimization problem where, given a set of items with weights and values, the goal is to determine the most valuable combination of items that can fit into a knapsack with a limited capacity. In this implementation, we use a greedy approach to solve the problem:

1.  **Calculate Value-to-Weight Ratio**: For each item, calculate the ratio of its value to its weight.
2.  **Sort Items**: Sort the items in descending order based on their value-to-weight ratio.
3.  **Select Items**: Iterate through the sorted items and add them to the knapsack if they fit within the remaining capacity.

This approach does not always provide optimal solution.

## Unit Tests

The unit tests aim to verify the correctness of the Knapsack Problem algorithm implementation. These tests include:

* Verifying that the algorithm returns at least one item when at least one item fits
* Verifying that the algorithm returns no items when no item fits
* Verifying the correctness of the solution for a defined problem instance
* Verifying that the correct number of elements are generated when creating a problem instance
* Verifying that the weight of the items does not exceed the knapsack capacity after solving the problem

## GUI Application

The GUI application allows generating knapsack problem instances and displaying results.

<img width="402" alt="image" src="https://github.com/user-attachments/assets/2f5e927a-e6e3-4ad6-8482-b198adaa68e2" />

## Project Structure

* `lab2_Knapsack/`: Library containing the core logic for solving the Knapsack Problem and console application.
* `GUI/`: Windows Forms GUI application.
* `UnitTests/`: Unit tests for the `KnapsackSolver` algorithm.
