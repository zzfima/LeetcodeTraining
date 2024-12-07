
# LeetCode 121: Best Time to Buy and Sell Stock

## Problem Statement

You are given an array `prices` where `prices[i]` represents the price of a given stock on the `i`-th day.  
You want to maximize your profit by choosing a single day to buy one stock and a different day to sell that stock.  
Return the maximum profit you can achieve. If you cannot achieve any profit, return `0`.

### Example:
#### Input:
```
prices = [7, 1, 5, 3, 6, 4]
```
#### Output:
```
5
```
#### Explanation:
Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.

---

## Constraints:
- `1 ≤ prices.length ≤ 10⁵`
- `0 ≤ prices[i] ≤ 10⁴`

---

## Approach

We iterate through the array while maintaining:
1. The **minimum price** encountered so far (`minPrice`).
2. The **maximum profit** calculated so far (`maxProfit`).

At each step:
- If the current price is less than `minPrice`, we update `minPrice`.
- Otherwise, we calculate the profit by selling at the current price and update `maxProfit` if the calculated profit is greater.

### Algorithm:
1. Initialize `minPrice` to a very large value (`int.MaxValue`).
2. Initialize `maxProfit` to `0`.
3. Loop through the array:
   - Update `minPrice` if the current price is lower.
   - Update `maxProfit` if selling at the current price yields a higher profit.
4. Return `maxProfit`.

---

## Implementation in C#

```csharp
using System;

class Solution
{
    public int MaxProfit(int[] prices)
    {
        // Initialize minimum price and maximum profit
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            // Update minimum price if the current price is lower
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                // Calculate profit and update maxProfit if needed
                int profit = price - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine("Maximum Profit: " + solution.MaxProfit(prices)); // Expected: 5
    }
}
```

---

## Explanation of Code
1. **`minPrice`**:
   - Tracks the minimum stock price seen so far.
   - For `prices = [7, 1, 5, 3, 6, 4]`, `minPrice` updates as follows: 7 → 1.
   
2. **`maxProfit`**:
   - Stores the maximum profit encountered so far.
   - In the same example, the profit updates to 4 and finally to 5.

3. **Complexity**:
   - **Time**: O(n), where `n` is the length of the array. The array is traversed once.
   - **Space**: O(1), as only a few variables are used.

---

## Additional Test Cases

### Test Case 1:
#### Input:
```
prices = [7, 6, 4, 3, 1]
```
#### Output:
```
0
```
#### Explanation:
No transaction can result in profit.

### Test Case 2:
#### Input:
```
prices = [2, 4, 1]
```
#### Output:
```
2
```
#### Explanation:
Buy on day 1 (price = 2) and sell on day 2 (price = 4), profit = 4 - 2 = 2.

---

## Summary

This approach efficiently calculates the maximum profit using a single pass through the array while maintaining constant space complexity. It is optimal and works well for the given constraints.
