import styles from './customtabs.module.css'
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs'
import 'react-tabs/style/react-tabs.css'
import TabContent from './Components/TabContent'

const listTabId = [
    { status: '0' },
    { status: '1' },
    { status: '2' },
    { status: '3' },
    { status: '4' },
]

function CustomTabs({ loginUserNumberPhone, profileUserNumberPhone }) {
    return (
        <div style={{ padding: 10 }}>
            <Tabs>
                <TabList>
                    <Tab>Tất cả</Tab>
                    <Tab>Tin đang đăng</Tab>
                    <Tab>Tin chờ phê duyệt</Tab>
                    <Tab>Tin bị từ chối</Tab>
                    <Tab>Tin ẩn</Tab>
                </TabList>
                {listTabId.map(({ status }) => (
                    <TabPanel key={status}>
                        <TabContent
                            status={status}
                            loginUserNumberPhone={loginUserNumberPhone}
                            profileUserNumberPhone={profileUserNumberPhone}
                        />
                    </TabPanel>
                ))}
            </Tabs>
        </div>
    )
}

export default CustomTabs
