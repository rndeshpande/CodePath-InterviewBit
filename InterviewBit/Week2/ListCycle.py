def detectCycle(self, A):
        fast = A
        slow = A
        found = False
        
        while(True):
            if slow.next is not None:
                slow = slow.next
            
            if fast.next is not None:
                fast = fast.next
            
            if fast.next is not None:
                fast = fast.next
            
            if fast == slow:
                found = True
                break;
        
        slow = A
        if found:
            while(slow.next is not None and fast.next is not None):
                if fast == slow:
                    return fast;
                    
                slow = slow.next
                fast = fast.next
            
                
        
        return None