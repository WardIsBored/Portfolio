-- Print.lua
print("Inspiring notes since coding sucks!")
while true do
local hi = {
    "Inspiring note",
    "Inspiring note",
    "Inspiring note",
    "Inspiring note",
    "Inspiring note",
    "Inspiring note",
    "Inspiring note",
    "Inspiring note"
}
for i,v in ipairs(hi) do
        print(v)
    end
os.execute("timeout /t 3 >nul")
os.execute("cls")
print("Inspiring notes since coding sucks!")
end