#!/bin/bash  
# Bash script  
echo "Hello World!"  
for file in ~/*; do
    echo "$(basename "$file")"
done