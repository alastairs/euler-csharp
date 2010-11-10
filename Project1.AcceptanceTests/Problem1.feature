Feature: Sum all multiples of 3 and 5 below 1000
	In order to solve problem one
	As a software craftsman
	I want to be told the sum of all the multiples of 3 and 5 below 1000

@mytag
Scenario: Sum all multiples of 3 and 5 below 1000
	Given a new calculator
	And a list of all numbers below 1000
	When the sum of all multiples of 3 and 5 is calculated
	Then the result should be 233168
