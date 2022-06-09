//Tests
pm.test("Status code should be 200", ()=>{
    pm.response.to.have.status(200);
})

pm.test("Body response should include 'result_count'", ()=>{
    pm.expect(pm.response.text()).to.include('result_count');
})

pm.test("'Result_count' should be 0",()=>{
    const response = pm.response.json();
    const count = response.meta.result_count;
    pm.expect(count).to.eql(0)
})