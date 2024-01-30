def generaterandoms(total)
  numbers = [0]
  i = 0
  while i < total
    numbers << Random.rand(10000)   # << appends to the end of an array. We don't need to make an object to use the random class, although if I wanted to use a specific seed, I could.
    i += 1
  end
  numbers
end

class Array #Modify the Array class
  def insertionSort #Method
    i = 0
    self.count.times { #Outer loop. Happens once per loop.
      i += 1
      j = i - 1
      key = self[i]
      if !self[j].nil? && !key.nil?
        while j >= 0 && self[j] > key #Inner loop, move item across until it's sorted
          self[j + 1] = self[j] #Move element
          j = j - 1 #Move to previous element
        end
      end
      self[j + 1] = key
    }
        self.pop()  #Remove trailing nil
  end
end

numbers = [0]
numbers = generaterandoms(25)
puts "Unsorted numbers, length ~25"
puts numbers.to_s
numbers.insertionSort()
puts "Sorted numbers, length ~25"
puts numbers.to_s

numbers = generaterandoms(75)
puts "Unsorted numbers, length ~75"
puts numbers.to_s
numbers.insertionSort()
puts "Sorted numbers, length ~75"
puts numbers.to_s
