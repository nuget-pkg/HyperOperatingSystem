#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`
rm -rf ../Global.Sys/Global.Sys/Shared
cp -rv ./HyperOperatingSystem/Shared ../Global.Sys/Global.Sys/
