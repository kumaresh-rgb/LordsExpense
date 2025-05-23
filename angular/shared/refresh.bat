@echo off
cd /d "E:\1 kumaresh\Lords Expense\LordsExpense\angular"
echo Running NSwag...
node_modules\.bin\nswag run shared\service.nswag
pause
