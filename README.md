# F# Mutability Bug: Unexpected Function Behavior

This example demonstrates a potential issue when using mutable variables in F# functions.  The `add` function uses the values of `x` and `y` at the time of the initial function call, not reflecting subsequent modifications.  This can lead to unexpected behavior if you expect the function to use the latest values of the mutable variables.

## Bug Description

The code defines two mutable variables, `x` and `y`.  The `add` function adds them together.  After the initial `add` call, `x` and `y` are modified.  A second `add` call is then made.  The expected behavior might be that `result2` reflects the updated values, but this is incorrect. The function only ever uses the values when the function was first called. 

## Solution

The solution avoids using mutable variables or explicitly passes updated values to the function.