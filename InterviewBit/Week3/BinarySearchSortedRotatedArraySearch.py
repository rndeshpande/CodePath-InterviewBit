def search(self, A, B):
        left, right = 0, len(A) - 1
        
        while left <= right:
            mid = left + (right - left) / 2
            
            if A[mid] == B:
                return mid
            elif (A[mid] >= A[left] and A[left] <= B < A[mid]) or \
                 (A[mid] < A[left] and not (A[mid] < B <= A[right])):
                right = mid - 1
            else:
                left = mid + 1

        return -1