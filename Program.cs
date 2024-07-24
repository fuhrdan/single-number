//*****************************************************************************
//** 136. Single Number leetcode                                             **
//** Used a hash table to find the number.  One for positive and one for     **
//** negative numbers.  Beats most of the other code.                   -Dan **
//*****************************************************************************


int singleNumber(int* nums, int numsSize) {
    int hash[20001] = {0};
    int negativeHash[20001] = {0};
    int min = 2147483647;
    int max = -214748360;
    int this = 0;
    for(int i = 0; i < numsSize; i++)
    {
        if(nums[i] >= 0)
        {
            hash[nums[i]]++;
        }
        else if(nums[i] < 0)
        {
            int neg = nums[i] * -1;
            negativeHash[neg]++;
        }
        if(nums[i] < min) min = nums[i];
        if(nums[i] > max) max = nums[i];
//        printf("nums[%d] = %d\n",i,nums[i]);
    }
//    printf("Min = %d, Max = %d\n",min,max);
    for(int i = min; i <= max; i++)
    {
        if(i > 0)
        {
            if(hash[i] == 1)
                this = i;
        }
        if(i < 0)
        {
            int neg = i * -1;
            if(negativeHash[neg] == 1)
                this = i;
        }
    }
    return this;
}