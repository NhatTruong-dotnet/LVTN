import styles from './customtabs.module.css'
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs'
import 'react-tabs/style/react-tabs.css'
import TabContent from './Components/TabContent'

const listTabId = [
    { id: '1' },
    { id: '2' },
    { id: '3' },
    { id: '4' },
    { id: '5' },
]

function CustomTabs(props) {
    return (
        <>
            <Tabs>
                <TabList>
                    <Tab>Tất cả</Tab>
                    <Tab>Tin đang đăng</Tab>
                    <Tab>Tin chờ phê duyệt</Tab>
                    <Tab>Tin bị từ chối</Tab>
                    <Tab>Tin ẩn</Tab>
                </TabList>
                {listTabId.map(({ id }) => (
                    <TabPanel key={id}>
                        <TabContent id={id} />
                    </TabPanel>
                ))}
            </Tabs>
        </>
    )
}

export default CustomTabs
