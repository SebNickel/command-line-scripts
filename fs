#!/bin/bash
if [[ ! "$1" =~ [0-9]+ ]]; then
    echo "Usage: fs <integer>"
    echo "Where <integer> is the new font size."
    exit 1
fi
printf '\33]50;%s\007' "xft:Inconsolata:size=$1"
