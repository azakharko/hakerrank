#!/bin/ruby

require 'json'
require 'stringio'

#
# Complete the 'checkMagazine' function below.
#
# The function accepts following parameters:
#  1. STRING_ARRAY magazine
#  2. STRING_ARRAY note
#

def checkMagazine(magazine, note)
    # Write your code here

    m_d = Hash.new(0)
    n_d = Hash.new(0)
    note.each { |n| n_d[n] = n_d[n] + 1 }
    magazine.each { |m| m_d[m] = m_d[m] + 1 }
    n_d.each { |key, value| m_d[key] = m_d[key] - value }
    puts m_d.values.any? { |v| v < 0 } ? "No" : "Yes"
end

first_multiple_input = gets.rstrip.split

m = first_multiple_input[0].to_i

n = first_multiple_input[1].to_i

magazine = gets.rstrip.split

note = gets.rstrip.split

checkMagazine magazine, note
