Problem: "Balanced Pairs"

Problem Statement:
You are given two sorted arrays of integers arr1 and arr2, and a target integer target.
Your task is to find all pairs (i, j) such that:
arr1[i] + arr2[j] == target

i and j are the indices of the elements in arrays arr1 and arr2, respectively.

Both arrays may contain duplicates, and you should include each valid pair of indices.

Example:

Input:

        0  1  2

arr1 = [1, 2, 3]

arr2 = [2, 3, 4]

target = 5

Output:

[[0, 2], [1, 1], [2, 0]]