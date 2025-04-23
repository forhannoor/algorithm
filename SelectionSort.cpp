#include <iostream>
#include <cstdio>

// Function to print int array.
void print_array(int numbers [], int array_size);

int main()
{
    int numbers[] = {20, 35, -15, 7, 55, 1, -22};
    // Find array length.
    int array_length = sizeof(numbers) / sizeof(numbers[0]);
    printf("Before sort:\n");
    print_array(numbers, array_length);

    // Start outer loop from right most element and go towards the left.
    for(int last_sorted_index = array_length - 1; last_sorted_index > 0; --last_sorted_index)
    {
        // Set the first element as largest.
        int largest_element_index = 0;

        for(int i = 1; i <= last_sorted_index; ++i)
        {
            if(numbers[i] > numbers[largest_element_index])
            {
                largest_element_index = i;
            }
        }

        std::swap(numbers[largest_element_index], numbers[last_sorted_index]);
    }

    printf("After sort:\n");
    print_array(numbers, array_length);
    return 0;
}

// Function to print int array.
void print_array(int numbers [], int array_size)
{
    for(int i = 0; i < array_size; ++i)
        printf("%d ", numbers[i]);

    printf("\n");
}