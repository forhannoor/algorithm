/*
 * Recursive staircase problem.
 * Given the number of stairs (i.e. 5) and number of steps that can be taken at a time (i.e. 1 step, 3 step etc.), the
 * program determines the number of ways to reach the top of the stair.
 */

#include <cstdio>

// Determines the number of ways destination can be reached.
// Starts at the top and ends at the bottom.
void number_ways(int num_stairs, int* steps, int step_variation, int &num_ways)
{
    // If hasn't reached destination.
    if(num_stairs > 0)
    {
        // Number of steps that can be taken at a time.
        int current_step;

        for(int i = 0; i < step_variation; ++i)
        {
            current_step = steps[i];

            if(num_stairs >= current_step)
            {
                number_ways(num_stairs - current_step, steps, step_variation, num_ways);
            }
        }
    }

    // If reached destination.
    else
    {
        ++num_ways;
    }
}

int main()
{
    int steps [] = {1, 3, 5};
    int number_stairs, num_ways = 0, step_variation = 3;
    printf("# of stairs:");
    scanf("%d", &number_stairs);
    number_ways(number_stairs, steps, step_variation, num_ways);
    printf("%d", num_ways);
    return 0;
}